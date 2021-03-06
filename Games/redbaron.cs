using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;
using System.IO;
using System.Text.RegularExpressions;
using HTTF = HiToText.Formatting;
using VBA = HiToText.Formatting.ConvertValueToByteArray;
using SetScore = HiToText.Formatting.ConvertValuesToBytes;
using HiToStr = HiToText.Formatting.ConvertByteArraysToStrings;
using TextParams = HiToText.Utils.TextDecodingParameters;

namespace HiGames
{
    class redbaron : Hiscore    
    {        
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            //Start of nv RAM
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 18)]
            public byte[] Unknown1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte Checksum1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Checksum2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Checksum3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public byte[] WouldBeTheRestOfRecord;

            //Start of .hi file
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Score7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name7;
        }

        public TextParams tParams = new TextParams();

        public redbaron()
        {
            m_numEntries = 7;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "redbaron";
            m_extensionsRequired = ".nv,.hi";

            tParams.Format =
                StringFormatFlag.NeedsSpecialMapping |
                StringFormatFlag.ASCIIUpper;

            tParams.AddMapping(' ', 0x4a / 2);
            tParams.AddMapping(' ', 0x00);

            tParams.AddOffset(new Offset(0x16 / 2, Offset.FlagOffsets.Upper));
        }

        public byte GetChecksum8 (int score, string name)
        {
            byte checksum8 = 0x00;
            byte[] datascore = ConvertScore(score.ToString());
            byte[] dataname = ConvertName(name);

            for (int i = 0; i < datascore.Length; i++)
                checksum8 += datascore[i];
            
            for (int i = 0; i < dataname.Length; i++)
                checksum8 += dataname[i];
            
            return checksum8; 
        }

        public string ConvertName(byte[] name)
        {
            byte[] tempname = new byte[3];
            for (int i = 0; i < 3; i++)
            {
                tempname[i] = (byte)(name[i] / 2);
            }
            return HTTF.ByteToString(tempname, tParams);
        }

        public byte[] ConvertName(string name)
        {
            byte[] toreturn = new byte[3];
            byte[] tempname = HTTF.StringToByte(name, tParams);
            
            for (int i = 0; i < 3; i++)
            {
                toreturn[i] = (byte)(tempname[i] * 2);
            }
            return toreturn;
        }

        public byte[] ConvertScore(string score)
        {
            return HiConvert.ReverseByteArray(HiConvert.IntToByteArrayHex(Convert.ToInt32(score), 2));
        }

        //Not standard, so need to create our own ConvertScore returning a string, as seen in_005
        public string ConvertScore(byte[] score)
        {
            return (HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(score)) * 10).ToString();
        }

        public override void SetHiScore(string[] args)
        {
            //int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]) / 10;
            string name = args[2].ToUpper().PadRight(3, ' ');

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            Regex rxScore = new Regex("^Score.*$");
            Regex rxName = new Regex("^Name.*$");
            Regex rxChecksum = new Regex("^Checksum.*$");

            //Determining rank.
            int rank = HTTF.DetermineRank(
                score, rxScore, hiscoreData, HTTF.ByteArrayToInt.Reversed);

            //Adjusting lower scores.
            List<Regex> adjusters = new List<Regex>(new Regex[] { rxScore, rxName, rxChecksum });
            hiscoreData = (HiscoreData)HTTF.AdjustScores(rank, hiscoreData, adjusters);

            //Replacing new scores.
            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, rxName, ConvertName));
            placements.Add(new Placement(score.ToString(), rxScore, ConvertScore));
            if (rank < 3)
            {
                placements.Add(new Placement(GetChecksum8(score, name).ToString(), rxChecksum,
                    HTTF.ConvertValuesToBytes.ConvertByte));
            }

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void ModifyName(int rank, string name)
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, new Regex("^Name.*$"), ConvertName));
            if (rank < 3)
            {
                placements.Add(new Placement(
                    GetChecksum8(GetScoreFromRank(hiscoreData, rank - 1), name).ToString(),
                    new Regex("^Checksum.*$"),
                    HTTF.ConvertValuesToBytes.ConvertByte));
            }

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank - 1, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        private int GetScoreFromRank(HiscoreData hiscore, int rank)
        {
            switch (rank)
            {
                case 0:
                    return Convert.ToInt32(HiToStr.Reversed(hiscore.Score1));
                case 1:
                    return Convert.ToInt32(HiToStr.Reversed(hiscore.Score2));
                case 2:
                    return Convert.ToInt32(HiToStr.Reversed(hiscore.Score3));
            }

            return -1;
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^Score.*$"), ConvertScore);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = Format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<DisplayData> formatting = new List<DisplayData>();
            formatting.Add(new DisplayData(null, DisplayData.CannedDisplay.AscendingFrom1));
            formatting.Add(new DisplayData(new Regex("^Score.*$"), ConvertScore));
            formatting.Add(new DisplayData(new Regex("^Name.*$"), ConvertName));
        
            retString += HTTF.HiToString(hiscoreData, formatting);
            
            return retString;
        }

        public override void SaveData()
        {
            byte[] nvRam = new byte[64];
            byte[] hiFile = new byte[43];
            for (int i = 0; i < m_data.Length; i++)
            {
                if (i < nvRam.Length)
                    nvRam[i] = m_data[i];
                else
                    hiFile[i - nvRam.Length] = m_data[i];
            }
            File.WriteAllBytes(m_fileNames[0], nvRam);
            File.WriteAllBytes(m_fileNames[1], hiFile);
        }
    }
}


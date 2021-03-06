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
    class astdelux : Hiscore    
    {        
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            //Start of nv RAM
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte Checksum1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Checksum2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Checksum3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 43)]
            public byte[] WouldBeTheRestOfRecord;

            //Start of .hi file
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score10;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
            public byte[] Dummy;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name10;
        }

        public TextParams tParams = new TextParams();

        public astdelux()
        {
            m_numEntries = 10;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "astdelux,astdelux1,astdelux2,astdelu1,astdelu2";
            m_extensionsRequired = ".nv,.hi";

            tParams.Format =
                StringFormatFlag.NeedsSpecialMapping |
                StringFormatFlag.ASCIIUpper;
            tParams.AddMapping(' ', 0x00);
            tParams.AddMapping(' ', 0xff);
            tParams.AddOffset(new Offset(0x0b, Offset.FlagOffsets.Upper));
        }

        //public byte GetChecksum8 (byte[] datascore, byte[] dataname)
        public byte GetChecksum8 (int score, string name)
        {
            VBA dScore = SetScore.ConvertData(score, 3, HiConvert.IntToByteArrayHex, HiConvert.ReverseByteArray);

            byte checksum8 = 0x00;
            byte[] datascore = dScore(score.ToString());
            byte[] dataname = SetScore.ConvertName(tParams)(name);

            for (int i = 0; i < datascore.Length; i++)
                checksum8 += datascore[i];
            
            for (int i = 0; i < dataname.Length; i++)
                checksum8 += dataname[i];
            
            return checksum8; 
        }

        public override void SetHiScore(string[] args)
        {
            //int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2].ToUpper().PadRight(3,' ');

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            Regex rxScore = new Regex("^Score.*$");
            Regex rxName = new Regex("^Name.*$");
            Regex rxChecksum = new Regex("^Checksum.*$");

            //Determining rank.
            int rank = HTTF.DetermineRank(score, rxScore, hiscoreData, HTTF.ByteArrayToInt.Reversed);

            //Adjusting lower scores.
            List<Regex> adjusters = new List<Regex>(new Regex[] { rxScore, rxName, rxChecksum });
            hiscoreData = (HiscoreData)HTTF.AdjustScores(rank, hiscoreData, adjusters);

            //Replacing new scores.
            VBA dScore = SetScore.ConvertData(score, hiscoreData.Score1.Length, HiConvert.IntToByteArrayHex, HiConvert.ReverseByteArray);

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, rxName, SetScore.ConvertName(tParams)));
            placements.Add(new Placement(score.ToString(), rxScore, dScore));
            if (rank < 3)
                placements.Add(new Placement(GetChecksum8(score, name).ToString(), rxChecksum, SetScore.ConvertByte));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public void ModifyName(int rank, string name)
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, new Regex("^Name.*$"), SetScore.ConvertName(tParams)));
            if (rank < 3)
            {
                placements.Add(new Placement(
                    GetChecksum8(GetScoreFromRank(hiscoreData, rank - 1), name).ToString(),
                    new Regex("^Checksum.*$"),
                    SetScore.ConvertByte));
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
            VBA dScore = SetScore.ConvertData(0, 3, HiConvert.IntToByteArrayHex, HiConvert.ReverseByteArray);

            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^Score.*$"), dScore);

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
            formatting.Add(new DisplayData(new Regex("^Score.*$"), HiToStr.Reversed));
            formatting.Add(new DisplayData(new Regex("^Name.*$"), HiToStr.ConvertName(tParams)));

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


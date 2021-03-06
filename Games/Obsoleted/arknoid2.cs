using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using System.Text.RegularExpressions;
using HTTF = HiToText.Formatting;
using VBA = HiToText.Formatting.ConvertValueToByteArray;
using SetScore = HiToText.Formatting.ConvertValuesToBytes;
using HiToStr = HiToText.Formatting.ConvertByteArraysToStrings;
using TextParams = HiToText.Utils.TextDecodingParameters;
using HiToText.Utils;

namespace HiGames
{
    class arknoid2 : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score1;
            public byte Round1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte Space1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score2;
            public byte Round2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Space2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score3;
            public byte Round3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Space3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score4;
            public byte Round4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            public byte Space4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score5;
            public byte Round5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
                        
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] HiScore;
        }

        public TextParams tParams = new TextParams();

        public arknoid2()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME|ROUND";
            m_gamesSupported = "arknoid2,arknid2j,arknid2u";
            m_extensionsRequired = ".hi";

            tParams.Format = StringFormatFlag.ASCIIStandard;
        }

        public override void SetHiScore(string[] args)
        {
            //int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]) / 10;
            string name = args[2].ToUpper().PadRight(3, ' ');
            int round = System.Convert.ToInt32(args[3]);

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            Regex rxScore = new Regex("^Score.*$");
            Regex rxHiScore = new Regex("^HiScore$");
            Regex rxName = new Regex("^Name.*$");
            Regex rxRound = new Regex("^Round.*$");

            //Determining rank.
            int rank = HTTF.DetermineRank(score, rxScore, hiscoreData, HTTF.ByteArrayToInt.Standard);

            //Adjusting lower scores.
            List<Regex> adjusters = new List<Regex>(new Regex[] { rxScore, rxName, rxRound });
            hiscoreData = (HiscoreData)HTTF.AdjustScores(rank, hiscoreData, adjusters);

            //Replacing new scores.
            //Delegate creation.
            VBA dScore = SetScore.ConvertData(score, hiscoreData.Score1.Length, HiConvert.IntToByteArrayHex);

            //Placement creation.
            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, rxName, SetScore.ConvertName(tParams)));
            placements.Add(new Placement(score.ToString(), rxScore, dScore));
            placements.Add(new Placement(score.ToString(), rxHiScore, true, dScore));
            placements.Add(new Placement(round.ToString(), rxRound, SetScore.ConvertByte));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public void ModifyName(int rank, string name)
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, new Regex("^Name.*$"), SetScore.ConvertName(tParams)));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank - 1, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            VBA dScore = SetScore.ConvertData(0, hiscoreData.Score1.Length, HiConvert.IntToByteArrayHex);

            //We also want to get the top score and empty that.
            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^.*Score.*$"), dScore);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<DisplayData> formatting = new List<DisplayData>();
            formatting.Add(new DisplayData(null, DisplayData.CannedDisplay.AscendingFrom1));
            formatting.Add(new DisplayData(new Regex("^Score.*$"), HiToStr.MultiplyDisplayed(HiToStr.Standard, 10)));
            formatting.Add(new DisplayData(new Regex("^Name.*$"), HiToStr.ConvertName(tParams)));
            formatting.Add(new DisplayData(new Regex("^Round.*$"), HiToStr.AddToDisplayed(HiToStr.Hex, 1)));

            retString += HTTF.HiToString(hiscoreData, formatting);

            return retString;
        }
    }
}
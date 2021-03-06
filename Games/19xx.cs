using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;
using System.Text.RegularExpressions;
using HTTF = HiToText.Formatting;
using VBA = HiToText.Formatting.ConvertValueToByteArray;
using SetScore = HiToText.Formatting.ConvertValuesToBytes;
using HiToStr = HiToText.Formatting.ConvertByteArraysToStrings;
using TextParams = HiToText.Utils.TextDecodingParameters;

namespace HiGames
{
    class _19xx : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] HiScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score1;
            public byte Plane1;
            public byte Level1;
            public byte UnusedA1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score2;
            public byte Plane2;
            public byte Level2;
            public byte UnusedA2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score3;
            public byte Plane3;
            public byte Level3;
            public byte UnusedA3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score4;
            public byte Plane4;
            public byte Level4;
            public byte UnusedA4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score5;
            public byte Plane5;
            public byte Level5;
            public byte UnusedA5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score6;
            public byte Plane6;
            public byte Level6;
            public byte UnusedA6;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score7;
            public byte Plane7;
            public byte Level7;
            public byte UnusedA7;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score8;
            public byte Plane8;
            public byte Level8;
            public byte UnusedA8;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score9;
            public byte Plane9;
            public byte Level9;
            public byte UnusedA9;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score10;
            public byte Plane10;
            public byte Level10;
            public byte UnusedA10;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score11;
            public byte Plane11;
            public byte Level11;
            public byte UnusedA11;
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Name12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score12;
            public byte Plane12;
            public byte Level12;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Accuracy7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TotalAccuracy;
        }

        public TextParams tParams = new TextParams();

        public _19xx()
        {
            m_numEntries = 12;
            m_format = "RANK|SCORE|NAME|PLANE|LEVEL";
            m_gamesSupported = "19xx,19xxa,19xxh,19xxjr1,19xxj,19xxb,19xxd";
            m_extensionsRequired = ".hi";

            m_altFormat = new string[1];
            m_altFormat[0] = "TOP SCORE STAGE ACCURACY" + Environment.NewLine + "STAGE|ACCURACY";
            m_numAltEntries = new int[] { 2 };

            tParams.Format = 
                StringFormatFlag.NeedsSpecialMapping |
                StringFormatFlag.ASCIIUpper |
                StringFormatFlag.ASCIILower |
                StringFormatFlag.ASCIINumbers;

            tParams.AddMapping('!', 0x34);
            tParams.AddMapping('#', 0x35);
            tParams.AddMapping('$', 0x36);
            tParams.AddMapping('%', 0x37);
            tParams.AddMapping('&', 0x38);
            tParams.AddMapping('(', 0x39);
            tParams.AddMapping(')', 0x3a);
            tParams.AddMapping(',', 0x3b);
            tParams.AddMapping('.', 0x3c);
            tParams.AddMapping(' ', 0x47);
            tParams.AddMapping(' ', 0xff);

            tParams.AddOffset(new Offset(0x00, Offset.FlagOffsets.Upper));
            tParams.AddOffset(new Offset(0x1a, Offset.FlagOffsets.Lower));
            tParams.AddOffset(new Offset(0x3d, Offset.FlagOffsets.Numbers));

            tParams.ByteSkipAmount = 2;
        }

        private int GetAlternateName(string altName)
        {
            switch (altName)
            {
                case "TOP SCORE STAGE ACCURACY":
                    return 0;
            }
            return -1;
        }

        public string ConvertName(byte[] name)
        {
            return HTTF.ByteToString(name, tParams);
        }

        public string ConvertLevel(byte[] level)
        {
            return ((int)level[0] + 1).ToString();
        }

        public string ConvertPlane(byte[] plane)
        {
            switch (plane[0])
            {
                case 0:
                    return "LIGHTNING(P1)";
                case 1:
                    return "SINDEN(P1)";
                case 2:
                    return "MOSQUITO(P1)";
                case 16:
                    return "LIGHTNING(P2)";
                case 17:
                    return "SINDEN(P2)";
                case 18:
                    return "MOSQUITO(P2)";
            }

            return "LIGHTNING(P1)";
        }

        public string ConvertAccuracy(byte[] acc)
        {
            int accAsInt = HiConvert.ByteArrayHexToInt(acc);

            if (accAsInt == 0)
                return "UNCLEARED";
            if (accAsInt == 100)
                return "PERFECT";

            return accAsInt.ToString() + "%";
        }

        public byte[] ConvertName(string name)
        {
            return HTTF.StringToByte(name, tParams);
        }

        public byte[] ConvertScore(string score)
        {
            return HiConvert.IntToByteArrayHex(Convert.ToInt32(score), 3);
        }

        public byte[] ConvertPlane(string plane)
        {
            switch (plane)
            {
                case "LIGHTNING(P1)":
                    return new byte[] { 0 };
                case "SINDEN(P1)":
                    return new byte[] { 1 };
                case "MOSQUITO(P1)":
                    return new byte[] { 2 };
                case "LIGHTNING(P2)":
                    return new byte[] { 16 };
                case "SINDEN(P2)":
                    return new byte[] { 17 };
                case "MOSQUITO(P2)":
                    return new byte[] { 18 };
            }
            return new byte[] { 0 };
        }

        public byte[] ConvertAccuracy(string acc)
        {
            if (acc.Equals("PERFECT"))
                return HiConvert.IntToByteArrayHex(100, 2);
            if (acc.Equals("UNCLEARED"))
                return HiConvert.IntToByteArrayHex(0, 2);

            return HiConvert.IntToByteArrayHex(Convert.ToInt32(acc.Replace("%", String.Empty)), 2);
        }

        private string GetAverageAccuracy(HiscoreData hiscoreData)
        {
            int[] acc = new int[7];
            acc[0] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy1);
            acc[1] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy2);
            acc[2] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy3);
            acc[3] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy4);
            acc[4] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy5);
            acc[5] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy6);
            acc[6] = HiConvert.ByteArrayHexToInt(hiscoreData.Accuracy7);

            int sum = 0;
            int nonZeroes = 7;
            for (int i = 0; i < acc.Length; i++)
            {
                if (acc[i] == 0)
                    nonZeroes--;
                else
                    sum += acc[i];
            }

            if (nonZeroes == 0)
                return "UNCLEARED";

            int avg = sum / nonZeroes;
            if (avg == 100)
                return "PERFECT";

            return avg.ToString() + "%";
        }

        public override void SetHiScore(string[] args)
        {
            //int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2].PadRight(3, ' ').ToUpper().Substring(0, 3);
            string plane = args[3];
            int level = System.Convert.ToInt32(args[4]) - 1;

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            Regex rxScore = new Regex("^Score.*$");
            Regex rxName = new Regex("^Name.*$");
            Regex rxPlane = new Regex("^Plane.*$");
            Regex rxLevel = new Regex("^Level.*$");

            //Determining rank.
            int rank = HTTF.DetermineRank(
                score, rxScore, hiscoreData, HTTF.ByteArrayToInt.Standard);

            //Adjusting lower scores.
            List<Regex> adjusters = new List<Regex>(new Regex[] { rxScore, rxName, rxPlane, rxLevel });
            hiscoreData = (HiscoreData)HTTF.AdjustScores(rank, hiscoreData, adjusters);

            //Replacing new scores.
            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, rxName, ConvertName));
            placements.Add(new Placement(score.ToString(), rxScore, ConvertScore));
            placements.Add(new Placement(score.ToString(), new Regex("^HiScore$"), true, ConvertScore));
            placements.Add(new Placement(plane, rxPlane, ConvertPlane));
            placements.Add(new Placement(level.ToString(), rxLevel, HTTF.ConvertValuesToBytes.ConvertByte));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void SetAlternateScore(string[] args)
        {
            int alternateName = GetAlternateName(args[0]);
            if (alternateName == -1)
                throw new Exception("Error: Invalid alternate score name.");

            int stage = Convert.ToInt32(args[1]);
            string accuracy = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(accuracy, new Regex("^Accuracy.*$"), ConvertAccuracy));
            
            hiscoreData = (HiscoreData)HTTF.ReplaceNew(stage - 1, hiscoreData, placements);

            //Set the average accuracy.
            HiConvert.ByteArrayCopy(hiscoreData.TotalAccuracy, ConvertAccuracy(GetAverageAccuracy(hiscoreData)));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void ModifyName(int rank, string name)
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, new Regex("^Name.*$"), ConvertName));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank - 1, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^.*Score.*$"), ConvertScore);

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

            //Rank.
            formatting.Add(new DisplayData(null, DisplayData.CannedDisplay.AscendingFrom1));
            formatting.Add(new DisplayData(
                new Regex("^Score[1-9]$|^Score10$"), HiToStr.Standard));
            formatting.Add(new DisplayData(new Regex("^Name[1-9]$|^Name10$"), ConvertName));
            formatting.Add(new DisplayData(new Regex("^Plane[1-9]$|^Plane10$"), ConvertPlane));
            formatting.Add(new DisplayData(new Regex("^Level[1-9]$|^Level10$"), ConvertLevel));

            retString += HTTF.HiToString(hiscoreData, formatting);

            retString += Environment.NewLine + Environment.NewLine + AltFormat[0] + Environment.NewLine;

            formatting.Clear();
            formatting.Add(new DisplayData(null, DisplayData.CannedDisplay.AscendingFrom1EndingInTotal, "AVERAGE"));
            formatting.Add(new DisplayData(new Regex("^.*Accuracy.*$"), ConvertAccuracy));

            retString += HTTF.HiToString(hiscoreData, formatting);

            return retString;
        }
    }
}
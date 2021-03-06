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
    class _1943 : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Separator6;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] HiScoreInvisible;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] HiScoreDisplayed;
        }

        public TextParams tParams = new TextParams();

        public _1943()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "1943,1943j,1943kai";
            m_extensionsRequired = ".hi";

            tParams.Format =
                StringFormatFlag.NeedsSpecialMapping |
                StringFormatFlag.ASCIIUpper |
                StringFormatFlag.ASCIINumbers;

            tParams.AddMapping(' ', 0x24);
            tParams.AddMapping('.', 0x2b);
            tParams.AddMapping(':', 0x2c);
            tParams.AddMapping('&', 0x3a);
            tParams.AddMapping('♥', 0x62);
            tParams.AddMapping('★', 0x64);
            tParams.AddMapping('!', 0x66);

            tParams.AddOffset(new Offset(0x0a, Offset.FlagOffsets.Upper));
            tParams.AddOffset(new Offset(0x00, Offset.FlagOffsets.Numbers));
        }

        public string ConvertName(byte[] name)
        {
            return HTTF.ByteToString(name, tParams);
        }

        public byte[] ConvertName(string name)
        {
            return HTTF.StringToByte(name, tParams);
        }

        public byte[] ConvertScore(string score)
        {
            return HiConvert.IntToByteArraySingleBCD(Convert.ToInt32(score), 8);
        }

        public byte[] ConvertHiScore(string score)
        {
            return IntToHiScoreDisplayed(Convert.ToInt32(score), 8);
        }

        public byte[] IntToHiScoreDisplayed(int score, int length)
        {
            byte[] modifiedScore = HiConvert.IntToByteArraySingleBCD(score, length);
            
            for (int i = 0; i < modifiedScore.Length; i++)
            {
                if (modifiedScore[i] == 0x00)
                    modifiedScore[i] = 0x24;
                else
                    break;
            }

            return modifiedScore;
        }

        public override void SetHiScore(string[] args)
        {
            //int rankGiven = System.Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            Regex rxScore = new Regex("^Score.*$");
            Regex rxName = new Regex("^Name.*$");

            //Determining rank.
            int rank = HTTF.DetermineRank(
                score, rxScore, hiscoreData, HTTF.ByteArrayToInt.BCD);

            //Adjusting lower scores.
            List<Regex> adjusters = new List<Regex>(new Regex[] { rxScore, rxName });
            hiscoreData = (HiscoreData)HTTF.AdjustScores(rank, hiscoreData, adjusters);

            //Replacing new scores.
            List<Placement> placements = new List<Placement>();
            placements.Add(new Placement(name, rxName, ConvertName));
            placements.Add(new Placement(score.ToString(), rxScore, ConvertScore));
            placements.Add(new Placement(score.ToString(), new Regex("^HiScoreInvisible$"), true, ConvertScore));
            placements.Add(new Placement(score.ToString(), new Regex("^HiScoreDisplayed$"), true, ConvertHiScore));

            hiscoreData = (HiscoreData)HTTF.ReplaceNew(rank, hiscoreData, placements);

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        //public override void ModifyName(int rank, string name)
        public void ModifyName(int rank, string name)
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

            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^Score.*$"), ConvertScore);
            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^HiScoreInvisible$"), ConvertScore);
            hiscoreData = (HiscoreData)HTTF.EmptyScores(hiscoreData, new Regex("^HiScoreDisplayed$"), ConvertHiScore);

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

            //We only want the top 5 scores, since that's all that's shown in-game.
            formatting.Add(new DisplayData(
                new Regex("^Score[1-5]$"), HiToStr.BCD));

            //Only want the top 5 names too.
            formatting.Add(new DisplayData(new Regex("^Name[1-5]$"), ConvertName));

            retString += HTTF.HiToString(hiscoreData, formatting);

            return retString;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class smashtv : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] HeaderA;

            public byte TodaysScore1Part1;
            public byte TodaysScore1Unused1;
            public byte TodaysScore1Part2;
            public byte TodaysScore1Unused2;
            public byte TodaysScore1Part3;
            public byte TodaysScore1Unused3;
            public byte TodaysScore1Part4;
            public byte TodaysScore1Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName1Unused;

            public byte TodaysScore2Part1;
            public byte TodaysScore2Unused1;
            public byte TodaysScore2Part2;
            public byte TodaysScore2Unused2;
            public byte TodaysScore2Part3;
            public byte TodaysScore2Unused3;
            public byte TodaysScore2Part4;
            public byte TodaysScore2Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName2Unused;

            public byte TodaysScore3Part1;
            public byte TodaysScore3Unused1;
            public byte TodaysScore3Part2;
            public byte TodaysScore3Unused2;
            public byte TodaysScore3Part3;
            public byte TodaysScore3Unused3;
            public byte TodaysScore3Part4;
            public byte TodaysScore3Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName3Unused;

            public byte TodaysScore4Part1;
            public byte TodaysScore4Unused1;
            public byte TodaysScore4Part2;
            public byte TodaysScore4Unused2;
            public byte TodaysScore4Part3;
            public byte TodaysScore4Unused3;
            public byte TodaysScore4Part4;
            public byte TodaysScore4Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName4Unused;

            public byte TodaysScore5Part1;
            public byte TodaysScore5Unused1;
            public byte TodaysScore5Part2;
            public byte TodaysScore5Unused2;
            public byte TodaysScore5Part3;
            public byte TodaysScore5Unused3;
            public byte TodaysScore5Part4;
            public byte TodaysScore5Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName5Unused;

            public byte TodaysScore6Part1;
            public byte TodaysScore6Unused1;
            public byte TodaysScore6Part2;
            public byte TodaysScore6Unused2;
            public byte TodaysScore6Part3;
            public byte TodaysScore6Unused3;
            public byte TodaysScore6Part4;
            public byte TodaysScore6Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName6Unused;

            public byte TodaysScore7Part1;
            public byte TodaysScore7Unused1;
            public byte TodaysScore7Part2;
            public byte TodaysScore7Unused2;
            public byte TodaysScore7Part3;
            public byte TodaysScore7Unused3;
            public byte TodaysScore7Part4;
            public byte TodaysScore7Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName7Unused;

            public byte TodaysScore8Part1;
            public byte TodaysScore8Unused1;
            public byte TodaysScore8Part2;
            public byte TodaysScore8Unused2;
            public byte TodaysScore8Part3;
            public byte TodaysScore8Unused3;
            public byte TodaysScore8Part4;
            public byte TodaysScore8Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName8Unused;

            public byte TodaysScore9Part1;
            public byte TodaysScore9Unused1;
            public byte TodaysScore9Part2;
            public byte TodaysScore9Unused2;
            public byte TodaysScore9Part3;
            public byte TodaysScore9Unused3;
            public byte TodaysScore9Part4;
            public byte TodaysScore9Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName9Unused;

            public byte TodaysScore10Part1;
            public byte TodaysScore10Unused1;
            public byte TodaysScore10Part2;
            public byte TodaysScore10Unused2;
            public byte TodaysScore10Part3;
            public byte TodaysScore10Unused3;
            public byte TodaysScore10Part4;
            public byte TodaysScore10Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] TodaysName10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] TodaysName10Unused;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16208)]
            public byte[] UnusedBigA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] HeaderB;

            public byte AllTimeScore1Part1;
            public byte AllTimeScore1Unused1;
            public byte AllTimeScore1Part2;
            public byte AllTimeScore1Unused2;
            public byte AllTimeScore1Part3;
            public byte AllTimeScore1Unused3;
            public byte AllTimeScore1Part4;
            public byte AllTimeScore1Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName1Unused;

            public byte AllTimeScore2Part1;
            public byte AllTimeScore2Unused1;
            public byte AllTimeScore2Part2;
            public byte AllTimeScore2Unused2;
            public byte AllTimeScore2Part3;
            public byte AllTimeScore2Unused3;
            public byte AllTimeScore2Part4;
            public byte AllTimeScore2Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName2Unused;

            public byte AllTimeScore3Part1;
            public byte AllTimeScore3Unused1;
            public byte AllTimeScore3Part2;
            public byte AllTimeScore3Unused2;
            public byte AllTimeScore3Part3;
            public byte AllTimeScore3Unused3;
            public byte AllTimeScore3Part4;
            public byte AllTimeScore3Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName3Unused;

            public byte AllTimeScore4Part1;
            public byte AllTimeScore4Unused1;
            public byte AllTimeScore4Part2;
            public byte AllTimeScore4Unused2;
            public byte AllTimeScore4Part3;
            public byte AllTimeScore4Unused3;
            public byte AllTimeScore4Part4;
            public byte AllTimeScore4Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName4Unused;

            public byte AllTimeScore5Part1;
            public byte AllTimeScore5Unused1;
            public byte AllTimeScore5Part2;
            public byte AllTimeScore5Unused2;
            public byte AllTimeScore5Part3;
            public byte AllTimeScore5Unused3;
            public byte AllTimeScore5Part4;
            public byte AllTimeScore5Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName5Unused;

            public byte AllTimeScore6Part1;
            public byte AllTimeScore6Unused1;
            public byte AllTimeScore6Part2;
            public byte AllTimeScore6Unused2;
            public byte AllTimeScore6Part3;
            public byte AllTimeScore6Unused3;
            public byte AllTimeScore6Part4;
            public byte AllTimeScore6Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName6Unused;

            public byte AllTimeScore7Part1;
            public byte AllTimeScore7Unused1;
            public byte AllTimeScore7Part2;
            public byte AllTimeScore7Unused2;
            public byte AllTimeScore7Part3;
            public byte AllTimeScore7Unused3;
            public byte AllTimeScore7Part4;
            public byte AllTimeScore7Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName7Unused;

            public byte AllTimeScore8Part1;
            public byte AllTimeScore8Unused1;
            public byte AllTimeScore8Part2;
            public byte AllTimeScore8Unused2;
            public byte AllTimeScore8Part3;
            public byte AllTimeScore8Unused3;
            public byte AllTimeScore8Part4;
            public byte AllTimeScore8Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName8Unused;

            public byte AllTimeScore9Part1;
            public byte AllTimeScore9Unused1;
            public byte AllTimeScore9Part2;
            public byte AllTimeScore9Unused2;
            public byte AllTimeScore9Part3;
            public byte AllTimeScore9Unused3;
            public byte AllTimeScore9Part4;
            public byte AllTimeScore9Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName9Unused;

            public byte AllTimeScore10Part1;
            public byte AllTimeScore10Unused1;
            public byte AllTimeScore10Part2;
            public byte AllTimeScore10Unused2;
            public byte AllTimeScore10Part3;
            public byte AllTimeScore10Unused3;
            public byte AllTimeScore10Part4;
            public byte AllTimeScore10Unused4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] AllTimeName10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] AllTimeName10Unused;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16208)]
            public byte[] UnusedBigB;
        }

        public smashtv()
        {
            m_numEntries = 10;
            m_format = "RANK|SCORE|NAME";
            m_altFormat = new string[] { "TODAYS HIGH SCORE" + Environment.NewLine + "RANK|SCORE|NAME" };
            m_numAltEntries = new int[] { 10 };
            m_gamesSupported = "smashtv";
            m_extensionsRequired = ".nv";
        }

        //TODO: Get more possible characters.
        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length / 2; i++)
                sb.Append((char)(int)data[i * 2]);

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length * 2];

            for (int i = 0; i < str.Length; i++)
            {
                data[i * 2] = (byte)((int)str[i]);
                data[(i * 2) + 1] = 0x00;
            }

            return data;
        }

        private int GetScoreFromParts(byte p1, byte p2, byte p3, byte p4)
        {
            return HiConvert.ByteArrayHexToInt(new byte[] { p1, p2, p3, p4 });
        }

        private int GetAlternateName(string altName)
        {
            switch (altName)
            {
                case "TODAYS HIGH SCORE":
                    return 0;
            }
            return -1;
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            if (score > GetScoreFromParts(hiscoreData.AllTimeScore1Part1, hiscoreData.AllTimeScore1Part2, hiscoreData.AllTimeScore1Part3, hiscoreData.AllTimeScore1Part4))
                rank = 0;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore2Part1, hiscoreData.AllTimeScore2Part2, hiscoreData.AllTimeScore2Part3, hiscoreData.AllTimeScore2Part4))
                rank = 1;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore3Part1, hiscoreData.AllTimeScore3Part2, hiscoreData.AllTimeScore3Part3, hiscoreData.AllTimeScore3Part4))
                rank = 2;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore4Part1, hiscoreData.AllTimeScore4Part2, hiscoreData.AllTimeScore4Part3, hiscoreData.AllTimeScore4Part4))
                rank = 3;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore5Part1, hiscoreData.AllTimeScore5Part2, hiscoreData.AllTimeScore5Part3, hiscoreData.AllTimeScore5Part4))
                rank = 4;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore6Part1, hiscoreData.AllTimeScore6Part2, hiscoreData.AllTimeScore6Part3, hiscoreData.AllTimeScore6Part4))
                rank = 5;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore7Part1, hiscoreData.AllTimeScore7Part2, hiscoreData.AllTimeScore7Part3, hiscoreData.AllTimeScore7Part4))
                rank = 6;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore8Part1, hiscoreData.AllTimeScore8Part2, hiscoreData.AllTimeScore8Part3, hiscoreData.AllTimeScore8Part4))
                rank = 7;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore9Part1, hiscoreData.AllTimeScore9Part2, hiscoreData.AllTimeScore9Part3, hiscoreData.AllTimeScore9Part4))
                rank = 8;
            else if (score > GetScoreFromParts(hiscoreData.AllTimeScore10Part1, hiscoreData.AllTimeScore10Part2, hiscoreData.AllTimeScore10Part3, hiscoreData.AllTimeScore10Part4))
                rank = 9;
            #endregion

            #region ADJUST
            int adjust = NumEntries - 1;
            if (rank < NumEntries - 1)
                adjust = NumEntries - 2;
            switch (adjust)
            {
                case 0:
                    hiscoreData.AllTimeScore2Part1 = hiscoreData.AllTimeScore1Part1;
                    hiscoreData.AllTimeScore2Part2 = hiscoreData.AllTimeScore1Part2;
                    hiscoreData.AllTimeScore2Part3 = hiscoreData.AllTimeScore1Part3;
                    hiscoreData.AllTimeScore2Part4 = hiscoreData.AllTimeScore1Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName2, hiscoreData.AllTimeName1);
                    break;
                case 1:
                    hiscoreData.AllTimeScore3Part1 = hiscoreData.AllTimeScore2Part1;
                    hiscoreData.AllTimeScore3Part2 = hiscoreData.AllTimeScore2Part2;
                    hiscoreData.AllTimeScore3Part3 = hiscoreData.AllTimeScore2Part3;
                    hiscoreData.AllTimeScore3Part4 = hiscoreData.AllTimeScore2Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName3, hiscoreData.AllTimeName2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    hiscoreData.AllTimeScore4Part1 = hiscoreData.AllTimeScore3Part1;
                    hiscoreData.AllTimeScore4Part2 = hiscoreData.AllTimeScore3Part2;
                    hiscoreData.AllTimeScore4Part3 = hiscoreData.AllTimeScore3Part3;
                    hiscoreData.AllTimeScore4Part4 = hiscoreData.AllTimeScore3Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName4, hiscoreData.AllTimeName3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    hiscoreData.AllTimeScore5Part1 = hiscoreData.AllTimeScore4Part1;
                    hiscoreData.AllTimeScore5Part2 = hiscoreData.AllTimeScore4Part2;
                    hiscoreData.AllTimeScore5Part3 = hiscoreData.AllTimeScore4Part3;
                    hiscoreData.AllTimeScore5Part4 = hiscoreData.AllTimeScore4Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName5, hiscoreData.AllTimeName4);
                    if (rank < 3)
                        goto case 2;
                    break;
                case 4:
                    hiscoreData.AllTimeScore6Part1 = hiscoreData.AllTimeScore5Part1;
                    hiscoreData.AllTimeScore6Part2 = hiscoreData.AllTimeScore5Part2;
                    hiscoreData.AllTimeScore6Part3 = hiscoreData.AllTimeScore5Part3;
                    hiscoreData.AllTimeScore6Part4 = hiscoreData.AllTimeScore5Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName6, hiscoreData.AllTimeName5);
                    if (rank < 4)
                        goto case 3;
                    break;
                case 5:
                    hiscoreData.AllTimeScore7Part1 = hiscoreData.AllTimeScore6Part1;
                    hiscoreData.AllTimeScore7Part2 = hiscoreData.AllTimeScore6Part2;
                    hiscoreData.AllTimeScore7Part3 = hiscoreData.AllTimeScore6Part3;
                    hiscoreData.AllTimeScore7Part4 = hiscoreData.AllTimeScore6Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName7, hiscoreData.AllTimeName6);
                    if (rank < 5)
                        goto case 4;
                    break;
                case 6:
                    hiscoreData.AllTimeScore8Part1 = hiscoreData.AllTimeScore7Part1;
                    hiscoreData.AllTimeScore8Part2 = hiscoreData.AllTimeScore7Part2;
                    hiscoreData.AllTimeScore8Part3 = hiscoreData.AllTimeScore7Part3;
                    hiscoreData.AllTimeScore8Part4 = hiscoreData.AllTimeScore7Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName8, hiscoreData.AllTimeName7);
                    if (rank < 6)
                        goto case 5;
                    break;
                case 7:
                    hiscoreData.AllTimeScore9Part1 = hiscoreData.AllTimeScore8Part1;
                    hiscoreData.AllTimeScore9Part2 = hiscoreData.AllTimeScore8Part2;
                    hiscoreData.AllTimeScore9Part3 = hiscoreData.AllTimeScore8Part3;
                    hiscoreData.AllTimeScore9Part4 = hiscoreData.AllTimeScore8Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName9, hiscoreData.AllTimeName8);
                    if (rank < 7)
                        goto case 6;
                    break;
                case 8:
                    hiscoreData.AllTimeScore10Part1 = hiscoreData.AllTimeScore9Part1;
                    hiscoreData.AllTimeScore10Part2 = hiscoreData.AllTimeScore9Part2;
                    hiscoreData.AllTimeScore10Part3 = hiscoreData.AllTimeScore9Part3;
                    hiscoreData.AllTimeScore10Part4 = hiscoreData.AllTimeScore9Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName10, hiscoreData.AllTimeName9);
                    if (rank < 8)
                        goto case 7;
                    break;
            }
            #endregion

            #region REPLACE_NEW
            byte[] scoreAsBytes = HiConvert.IntToByteArrayHex(score, 4);
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName1, StringToByteArray(name));
                    hiscoreData.AllTimeScore1Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore1Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore1Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore1Part4 = scoreAsBytes[3];
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName2, StringToByteArray(name));
                    hiscoreData.AllTimeScore2Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore2Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore2Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore2Part4 = scoreAsBytes[3];
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName3, StringToByteArray(name));
                    hiscoreData.AllTimeScore3Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore3Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore3Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore3Part4 = scoreAsBytes[3];
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName4, StringToByteArray(name));
                    hiscoreData.AllTimeScore4Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore4Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore4Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore4Part4 = scoreAsBytes[3];
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName5, StringToByteArray(name));
                    hiscoreData.AllTimeScore5Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore5Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore5Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore5Part4 = scoreAsBytes[3];
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName6, StringToByteArray(name));
                    hiscoreData.AllTimeScore6Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore6Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore6Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore6Part4 = scoreAsBytes[3];
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName7, StringToByteArray(name));
                    hiscoreData.AllTimeScore7Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore7Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore7Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore7Part4 = scoreAsBytes[3];
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName8, StringToByteArray(name));
                    hiscoreData.AllTimeScore8Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore8Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore8Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore8Part4 = scoreAsBytes[3];
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName9, StringToByteArray(name));
                    hiscoreData.AllTimeScore9Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore9Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore9Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore9Part4 = scoreAsBytes[3];
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.AllTimeName10, StringToByteArray(name));
                    hiscoreData.AllTimeScore10Part1 = scoreAsBytes[0];
                    hiscoreData.AllTimeScore10Part2 = scoreAsBytes[1];
                    hiscoreData.AllTimeScore10Part3 = scoreAsBytes[2];
                    hiscoreData.AllTimeScore10Part4 = scoreAsBytes[3];
                    break;
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void SetAlternateScore(string[] args)
        {
            int alternateName = GetAlternateName(args[0]);
            int rankGiven = Convert.ToInt32(args[1]);
            int score = System.Convert.ToInt32(args[2]);
            string name = args[3];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumAltEntries[alternateName];
            if (score > GetScoreFromParts(hiscoreData.TodaysScore1Part1, hiscoreData.TodaysScore1Part2, hiscoreData.TodaysScore1Part3, hiscoreData.TodaysScore1Part4))
                rank = 0;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore2Part1, hiscoreData.TodaysScore2Part2, hiscoreData.TodaysScore2Part3, hiscoreData.TodaysScore2Part4))
                rank = 1;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore3Part1, hiscoreData.TodaysScore3Part2, hiscoreData.TodaysScore3Part3, hiscoreData.TodaysScore3Part4))
                rank = 2;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore4Part1, hiscoreData.TodaysScore4Part2, hiscoreData.TodaysScore4Part3, hiscoreData.TodaysScore4Part4))
                rank = 3;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore5Part1, hiscoreData.TodaysScore5Part2, hiscoreData.TodaysScore5Part3, hiscoreData.TodaysScore5Part4))
                rank = 4;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore6Part1, hiscoreData.TodaysScore6Part2, hiscoreData.TodaysScore6Part3, hiscoreData.TodaysScore6Part4))
                rank = 5;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore7Part1, hiscoreData.TodaysScore7Part2, hiscoreData.TodaysScore7Part3, hiscoreData.TodaysScore7Part4))
                rank = 6;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore8Part1, hiscoreData.TodaysScore8Part2, hiscoreData.TodaysScore8Part3, hiscoreData.TodaysScore8Part4))
                rank = 7;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore9Part1, hiscoreData.TodaysScore9Part2, hiscoreData.TodaysScore9Part3, hiscoreData.TodaysScore9Part4))
                rank = 8;
            else if (score > GetScoreFromParts(hiscoreData.TodaysScore10Part1, hiscoreData.TodaysScore10Part2, hiscoreData.TodaysScore10Part3, hiscoreData.TodaysScore10Part4))
                rank = 9;
            #endregion

            #region ADJUST
            int adjust = NumAltEntries[alternateName] - 1;
            if (rank < NumAltEntries[alternateName] - 1)
                adjust = NumAltEntries[alternateName] - 2;
            switch (adjust)
            {
                case 0:
                    hiscoreData.TodaysScore2Part1 = hiscoreData.TodaysScore1Part1;
                    hiscoreData.TodaysScore2Part2 = hiscoreData.TodaysScore1Part2;
                    hiscoreData.TodaysScore2Part3 = hiscoreData.TodaysScore1Part3;
                    hiscoreData.TodaysScore2Part4 = hiscoreData.TodaysScore1Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName2, hiscoreData.TodaysName1);
                    break;
                case 1:
                    hiscoreData.TodaysScore3Part1 = hiscoreData.TodaysScore2Part1;
                    hiscoreData.TodaysScore3Part2 = hiscoreData.TodaysScore2Part2;
                    hiscoreData.TodaysScore3Part3 = hiscoreData.TodaysScore2Part3;
                    hiscoreData.TodaysScore3Part4 = hiscoreData.TodaysScore2Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName3, hiscoreData.TodaysName2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    hiscoreData.TodaysScore4Part1 = hiscoreData.TodaysScore3Part1;
                    hiscoreData.TodaysScore4Part2 = hiscoreData.TodaysScore3Part2;
                    hiscoreData.TodaysScore4Part3 = hiscoreData.TodaysScore3Part3;
                    hiscoreData.TodaysScore4Part4 = hiscoreData.TodaysScore3Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName4, hiscoreData.TodaysName3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    hiscoreData.TodaysScore5Part1 = hiscoreData.TodaysScore4Part1;
                    hiscoreData.TodaysScore5Part2 = hiscoreData.TodaysScore4Part2;
                    hiscoreData.TodaysScore5Part3 = hiscoreData.TodaysScore4Part3;
                    hiscoreData.TodaysScore5Part4 = hiscoreData.TodaysScore4Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName5, hiscoreData.TodaysName4);
                    if (rank < 3)
                        goto case 2;
                    break;
                case 4:
                    hiscoreData.TodaysScore6Part1 = hiscoreData.TodaysScore5Part1;
                    hiscoreData.TodaysScore6Part2 = hiscoreData.TodaysScore5Part2;
                    hiscoreData.TodaysScore6Part3 = hiscoreData.TodaysScore5Part3;
                    hiscoreData.TodaysScore6Part4 = hiscoreData.TodaysScore5Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName6, hiscoreData.TodaysName5);
                    if (rank < 4)
                        goto case 3;
                    break;
                case 5:
                    hiscoreData.TodaysScore7Part1 = hiscoreData.TodaysScore6Part1;
                    hiscoreData.TodaysScore7Part2 = hiscoreData.TodaysScore6Part2;
                    hiscoreData.TodaysScore7Part3 = hiscoreData.TodaysScore6Part3;
                    hiscoreData.TodaysScore7Part4 = hiscoreData.TodaysScore6Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName7, hiscoreData.TodaysName6);
                    if (rank < 5)
                        goto case 4;
                    break;
                case 6:
                    hiscoreData.TodaysScore8Part1 = hiscoreData.TodaysScore7Part1;
                    hiscoreData.TodaysScore8Part2 = hiscoreData.TodaysScore7Part2;
                    hiscoreData.TodaysScore8Part3 = hiscoreData.TodaysScore7Part3;
                    hiscoreData.TodaysScore8Part4 = hiscoreData.TodaysScore7Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName8, hiscoreData.TodaysName7);
                    if (rank < 6)
                        goto case 5;
                    break;
                case 7:
                    hiscoreData.TodaysScore9Part1 = hiscoreData.TodaysScore8Part1;
                    hiscoreData.TodaysScore9Part2 = hiscoreData.TodaysScore8Part2;
                    hiscoreData.TodaysScore9Part3 = hiscoreData.TodaysScore8Part3;
                    hiscoreData.TodaysScore9Part4 = hiscoreData.TodaysScore8Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName9, hiscoreData.TodaysName8);
                    if (rank < 7)
                        goto case 6;
                    break;
                case 8:
                    hiscoreData.TodaysScore10Part1 = hiscoreData.TodaysScore9Part1;
                    hiscoreData.TodaysScore10Part2 = hiscoreData.TodaysScore9Part2;
                    hiscoreData.TodaysScore10Part3 = hiscoreData.TodaysScore9Part3;
                    hiscoreData.TodaysScore10Part4 = hiscoreData.TodaysScore9Part4;
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName10, hiscoreData.TodaysName9);
                    if (rank < 8)
                        goto case 7;
                    break;
            }
            #endregion

            #region REPLACE_NEW
            byte[] scoreAsBytes = HiConvert.IntToByteArrayHex(score, 4);
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName1, StringToByteArray(name));
                    hiscoreData.TodaysScore1Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore1Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore1Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore1Part4 = scoreAsBytes[3];
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName2, StringToByteArray(name));
                    hiscoreData.TodaysScore2Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore2Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore2Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore2Part4 = scoreAsBytes[3];
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName3, StringToByteArray(name));
                    hiscoreData.TodaysScore3Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore3Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore3Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore3Part4 = scoreAsBytes[3];
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName4, StringToByteArray(name));
                    hiscoreData.TodaysScore4Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore4Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore4Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore4Part4 = scoreAsBytes[3];
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName5, StringToByteArray(name));
                    hiscoreData.TodaysScore5Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore5Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore5Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore5Part4 = scoreAsBytes[3];
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName6, StringToByteArray(name));
                    hiscoreData.TodaysScore6Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore6Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore6Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore6Part4 = scoreAsBytes[3];
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName7, StringToByteArray(name));
                    hiscoreData.TodaysScore7Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore7Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore7Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore7Part4 = scoreAsBytes[3];
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName8, StringToByteArray(name));
                    hiscoreData.TodaysScore8Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore8Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore8Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore8Part4 = scoreAsBytes[3];
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName9, StringToByteArray(name));
                    hiscoreData.TodaysScore9Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore9Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore9Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore9Part4 = scoreAsBytes[3];
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.TodaysName10, StringToByteArray(name));
                    hiscoreData.TodaysScore10Part1 = scoreAsBytes[0];
                    hiscoreData.TodaysScore10Part2 = scoreAsBytes[1];
                    hiscoreData.TodaysScore10Part3 = scoreAsBytes[2];
                    hiscoreData.TodaysScore10Part4 = scoreAsBytes[3];
                    break;
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            hiscoreData.AllTimeScore1Part1 = 0x00;
            hiscoreData.AllTimeScore1Part2 = 0x00;
            hiscoreData.AllTimeScore1Part3 = 0x00;
            hiscoreData.AllTimeScore1Part4 = 0x00;
            hiscoreData.AllTimeScore2Part1 = 0x00;
            hiscoreData.AllTimeScore2Part2 = 0x00;
            hiscoreData.AllTimeScore2Part3 = 0x00;
            hiscoreData.AllTimeScore2Part4 = 0x00;
            hiscoreData.AllTimeScore3Part1 = 0x00;
            hiscoreData.AllTimeScore3Part2 = 0x00;
            hiscoreData.AllTimeScore3Part3 = 0x00;
            hiscoreData.AllTimeScore3Part4 = 0x00;
            hiscoreData.AllTimeScore4Part1 = 0x00;
            hiscoreData.AllTimeScore4Part2 = 0x00;
            hiscoreData.AllTimeScore4Part3 = 0x00;
            hiscoreData.AllTimeScore4Part4 = 0x00;
            hiscoreData.AllTimeScore5Part1 = 0x00;
            hiscoreData.AllTimeScore5Part2 = 0x00;
            hiscoreData.AllTimeScore5Part3 = 0x00;
            hiscoreData.AllTimeScore5Part4 = 0x00;
            hiscoreData.AllTimeScore6Part1 = 0x00;
            hiscoreData.AllTimeScore6Part2 = 0x00;
            hiscoreData.AllTimeScore6Part3 = 0x00;
            hiscoreData.AllTimeScore6Part4 = 0x00;
            hiscoreData.AllTimeScore7Part1 = 0x00;
            hiscoreData.AllTimeScore7Part2 = 0x00;
            hiscoreData.AllTimeScore7Part3 = 0x00;
            hiscoreData.AllTimeScore7Part4 = 0x00;
            hiscoreData.AllTimeScore8Part1 = 0x00;
            hiscoreData.AllTimeScore8Part2 = 0x00;
            hiscoreData.AllTimeScore8Part3 = 0x00;
            hiscoreData.AllTimeScore8Part4 = 0x00;
            hiscoreData.AllTimeScore9Part1 = 0x00;
            hiscoreData.AllTimeScore9Part2 = 0x00;
            hiscoreData.AllTimeScore9Part3 = 0x00;
            hiscoreData.AllTimeScore9Part4 = 0x00;
            hiscoreData.AllTimeScore10Part1 = 0x00;
            hiscoreData.AllTimeScore10Part2 = 0x00;
            hiscoreData.AllTimeScore10Part3 = 0x00;
            hiscoreData.AllTimeScore10Part4 = 0x00;

            hiscoreData.TodaysScore1Part1 = 0x00;
            hiscoreData.TodaysScore1Part2 = 0x00;
            hiscoreData.TodaysScore1Part3 = 0x00;
            hiscoreData.TodaysScore1Part4 = 0x00;
            hiscoreData.TodaysScore2Part1 = 0x00;
            hiscoreData.TodaysScore2Part2 = 0x00;
            hiscoreData.TodaysScore2Part3 = 0x00;
            hiscoreData.TodaysScore2Part4 = 0x00;
            hiscoreData.TodaysScore3Part1 = 0x00;
            hiscoreData.TodaysScore3Part2 = 0x00;
            hiscoreData.TodaysScore3Part3 = 0x00;
            hiscoreData.TodaysScore3Part4 = 0x00;
            hiscoreData.TodaysScore4Part1 = 0x00;
            hiscoreData.TodaysScore4Part2 = 0x00;
            hiscoreData.TodaysScore4Part3 = 0x00;
            hiscoreData.TodaysScore4Part4 = 0x00;
            hiscoreData.TodaysScore5Part1 = 0x00;
            hiscoreData.TodaysScore5Part2 = 0x00;
            hiscoreData.TodaysScore5Part3 = 0x00;
            hiscoreData.TodaysScore5Part4 = 0x00;
            hiscoreData.TodaysScore6Part1 = 0x00;
            hiscoreData.TodaysScore6Part2 = 0x00;
            hiscoreData.TodaysScore6Part3 = 0x00;
            hiscoreData.TodaysScore6Part4 = 0x00;
            hiscoreData.TodaysScore7Part1 = 0x00;
            hiscoreData.TodaysScore7Part2 = 0x00;
            hiscoreData.TodaysScore7Part3 = 0x00;
            hiscoreData.TodaysScore7Part4 = 0x00;
            hiscoreData.TodaysScore8Part1 = 0x00;
            hiscoreData.TodaysScore8Part2 = 0x00;
            hiscoreData.TodaysScore8Part3 = 0x00;
            hiscoreData.TodaysScore8Part4 = 0x00;
            hiscoreData.TodaysScore9Part1 = 0x00;
            hiscoreData.TodaysScore9Part2 = 0x00;
            hiscoreData.TodaysScore9Part3 = 0x00;
            hiscoreData.TodaysScore9Part4 = 0x00;
            hiscoreData.TodaysScore10Part1 = 0x00;
            hiscoreData.TodaysScore10Part2 = 0x00;
            hiscoreData.TodaysScore10Part3 = 0x00;
            hiscoreData.TodaysScore10Part4 = 0x00;
            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = Format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}", 1, GetScoreFromParts(hiscoreData.AllTimeScore1Part1, hiscoreData.AllTimeScore1Part2, hiscoreData.AllTimeScore1Part3, hiscoreData.AllTimeScore1Part4), ByteArrayToString(hiscoreData.AllTimeName1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, GetScoreFromParts(hiscoreData.AllTimeScore2Part1, hiscoreData.AllTimeScore2Part2, hiscoreData.AllTimeScore2Part3, hiscoreData.AllTimeScore2Part4), ByteArrayToString(hiscoreData.AllTimeName2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, GetScoreFromParts(hiscoreData.AllTimeScore3Part1, hiscoreData.AllTimeScore3Part2, hiscoreData.AllTimeScore3Part3, hiscoreData.AllTimeScore3Part4), ByteArrayToString(hiscoreData.AllTimeName3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, GetScoreFromParts(hiscoreData.AllTimeScore4Part1, hiscoreData.AllTimeScore4Part2, hiscoreData.AllTimeScore4Part3, hiscoreData.AllTimeScore4Part4), ByteArrayToString(hiscoreData.AllTimeName4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, GetScoreFromParts(hiscoreData.AllTimeScore5Part1, hiscoreData.AllTimeScore5Part2, hiscoreData.AllTimeScore5Part3, hiscoreData.AllTimeScore5Part4), ByteArrayToString(hiscoreData.AllTimeName5)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 6, GetScoreFromParts(hiscoreData.AllTimeScore6Part1, hiscoreData.AllTimeScore6Part2, hiscoreData.AllTimeScore6Part3, hiscoreData.AllTimeScore6Part4), ByteArrayToString(hiscoreData.AllTimeName6)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 7, GetScoreFromParts(hiscoreData.AllTimeScore7Part1, hiscoreData.AllTimeScore7Part2, hiscoreData.AllTimeScore7Part3, hiscoreData.AllTimeScore7Part4), ByteArrayToString(hiscoreData.AllTimeName7)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 8, GetScoreFromParts(hiscoreData.AllTimeScore8Part1, hiscoreData.AllTimeScore8Part2, hiscoreData.AllTimeScore8Part3, hiscoreData.AllTimeScore8Part4), ByteArrayToString(hiscoreData.AllTimeName8)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 9, GetScoreFromParts(hiscoreData.AllTimeScore9Part1, hiscoreData.AllTimeScore9Part2, hiscoreData.AllTimeScore9Part3, hiscoreData.AllTimeScore9Part4), ByteArrayToString(hiscoreData.AllTimeName9)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 10, GetScoreFromParts(hiscoreData.AllTimeScore10Part1, hiscoreData.AllTimeScore10Part2, hiscoreData.AllTimeScore10Part3, hiscoreData.AllTimeScore10Part4), ByteArrayToString(hiscoreData.AllTimeName10)) + Environment.NewLine;

            retString += Environment.NewLine + Environment.NewLine + AltFormat[0] + Environment.NewLine;

            retString += String.Format("{0}|{1}|{2}", 1, GetScoreFromParts(hiscoreData.TodaysScore1Part1, hiscoreData.TodaysScore1Part2, hiscoreData.TodaysScore1Part3, hiscoreData.TodaysScore1Part4), ByteArrayToString(hiscoreData.TodaysName1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, GetScoreFromParts(hiscoreData.TodaysScore2Part1, hiscoreData.TodaysScore2Part2, hiscoreData.TodaysScore2Part3, hiscoreData.TodaysScore2Part4), ByteArrayToString(hiscoreData.TodaysName2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, GetScoreFromParts(hiscoreData.TodaysScore3Part1, hiscoreData.TodaysScore3Part2, hiscoreData.TodaysScore3Part3, hiscoreData.TodaysScore3Part4), ByteArrayToString(hiscoreData.TodaysName3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, GetScoreFromParts(hiscoreData.TodaysScore4Part1, hiscoreData.TodaysScore4Part2, hiscoreData.TodaysScore4Part3, hiscoreData.TodaysScore4Part4), ByteArrayToString(hiscoreData.TodaysName4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, GetScoreFromParts(hiscoreData.TodaysScore5Part1, hiscoreData.TodaysScore5Part2, hiscoreData.TodaysScore5Part3, hiscoreData.TodaysScore5Part4), ByteArrayToString(hiscoreData.TodaysName5)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 6, GetScoreFromParts(hiscoreData.TodaysScore6Part1, hiscoreData.TodaysScore6Part2, hiscoreData.TodaysScore6Part3, hiscoreData.TodaysScore6Part4), ByteArrayToString(hiscoreData.TodaysName6)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 7, GetScoreFromParts(hiscoreData.TodaysScore7Part1, hiscoreData.TodaysScore7Part2, hiscoreData.TodaysScore7Part3, hiscoreData.TodaysScore7Part4), ByteArrayToString(hiscoreData.TodaysName7)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 8, GetScoreFromParts(hiscoreData.TodaysScore8Part1, hiscoreData.TodaysScore8Part2, hiscoreData.TodaysScore8Part3, hiscoreData.TodaysScore8Part4), ByteArrayToString(hiscoreData.TodaysName8)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 9, GetScoreFromParts(hiscoreData.TodaysScore9Part1, hiscoreData.TodaysScore9Part2, hiscoreData.TodaysScore9Part3, hiscoreData.TodaysScore9Part4), ByteArrayToString(hiscoreData.TodaysName9)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 10, GetScoreFromParts(hiscoreData.TodaysScore10Part1, hiscoreData.TodaysScore10Part2, hiscoreData.TodaysScore10Part3, hiscoreData.TodaysScore10Part4), ByteArrayToString(hiscoreData.TodaysName10)) + Environment.NewLine;

            return retString;
        }
    }
}


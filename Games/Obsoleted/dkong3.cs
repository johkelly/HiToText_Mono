using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class dkong3 : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] UnknownA1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedA1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedB1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] UnusedC1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownC1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ShortScore1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownD1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] UnknownA2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedA2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedB2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] UnusedC2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownC2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ShortScore2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownD2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] UnknownA3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedA3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedB3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] UnusedC3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownC3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ShortScore3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownD3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] UnknownA4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedA4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedB4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] UnusedC4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownC4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ShortScore4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownD4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] UnknownA5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedA5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnusedB5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
            public byte[] UnusedC5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownC5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ShortScore5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] UnknownD5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 68)]
            public byte[] UnusedHiScoreArea;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] HiScore;
        }

        public dkong3()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "dkong3,dkong3j,dkong3b";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0x41 && data[i] <= 0x5a)
                    sb.Append((char)(int)data[i]);
                else if (data[i] == 0x66)
                    sb.Append('.');
                else if (data[i] == 0x5f)
                    sb.Append('-');
                else if (data[i] == 0x40)
                    sb.Append(' ');
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    data[i] = (byte)((int)str[i]);
                else if (str[i] == '.')
                    data[i] = 0x66;
                else if (str[i] == '-')
                    data[i] = 0x5f;
                else if (str[i] == ' ')
                    data[i] = 0x40;
            }

            return data;
        }

        public int ByteArrayToScore(byte[] byteData)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < byteData.Length; i++)
                sb.Append(byteData[i].ToString("X2").Substring(1, 1));

            return Int32.Parse(sb.ToString());
        }

        public byte[] ScoreToByteArray(int score)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byteArray = HiConvert.IntToByteArrayHex(score, 4);

            for (int i = 1; i < byteArray.Length; i++)
            {
                string byteStr = byteArray[i].ToString("X2");
                sb.Append("3" + byteStr[0]);
                sb.Append("3" + byteStr[1]);
            }

            return HiConvert.HexStringToByteArray(sb.ToString());
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = System.Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[1];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = 5;
            if (score > ByteArrayToScore(hiscoreData.Score1))
                rank = 0;
            else if (score > ByteArrayToScore(hiscoreData.Score2))
                rank = 1;
            else if (score > ByteArrayToScore(hiscoreData.Score3))
                rank = 2;
            else if (score > ByteArrayToScore(hiscoreData.Score4))
                rank = 3;
            else if (score > ByteArrayToScore(hiscoreData.Score5))
                rank = 4;
            #endregion

            #region ADJUST
            int adjust = 4;
            if (rank < 4)
                adjust = 3;
            switch (adjust)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, hiscoreData.Score1);
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore2, hiscoreData.ShortScore1);
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, hiscoreData.Name1);
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, hiscoreData.Score2);
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore3, hiscoreData.ShortScore2);
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, hiscoreData.Score3);
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore4, hiscoreData.ShortScore3);
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, hiscoreData.Score4);
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore5, hiscoreData.ShortScore4);
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, hiscoreData.Name4);
                    if (rank < 3)
                        goto case 2;
                    break;
                default:
                    break;
            }
            #endregion

            #region REPLACE_NEW
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Name1, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, ScoreToByteArray(score));
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore1, HiConvert.ReverseByteArray(HiConvert.HexStringToByteArray(score.ToString("D6"))));
                    HiConvert.ByteArrayCopy(hiscoreData.HiScore, HiConvert.HexStringToByteArray(score.ToString("D6")));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, ScoreToByteArray(score));
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore2, HiConvert.ReverseByteArray(HiConvert.HexStringToByteArray(score.ToString("D6"))));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, ScoreToByteArray(score));
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore3, HiConvert.ReverseByteArray(HiConvert.HexStringToByteArray(score.ToString("D6"))));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, ScoreToByteArray(score));
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore4, HiConvert.ReverseByteArray(HiConvert.HexStringToByteArray(score.ToString("D6"))));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, ScoreToByteArray(score));
                    HiConvert.ByteArrayCopy(hiscoreData.ShortScore5, HiConvert.ReverseByteArray(HiConvert.HexStringToByteArray(score.ToString("D6"))));
                    break;
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            
            HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.HexStringToByteArray("303030303030"));
            HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.HexStringToByteArray("303030303030"));
            HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.HexStringToByteArray("303030303030"));
            HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.HexStringToByteArray("303030303030"));
            HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.HexStringToByteArray("303030303030"));

            HiConvert.ByteArrayCopy(hiscoreData.ShortScore1, HiConvert.IntToByteArrayHex(0, hiscoreData.ShortScore1.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ShortScore2, HiConvert.IntToByteArrayHex(0, hiscoreData.ShortScore2.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ShortScore3, HiConvert.IntToByteArrayHex(0, hiscoreData.ShortScore3.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ShortScore4, HiConvert.IntToByteArrayHex(0, hiscoreData.ShortScore4.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ShortScore5, HiConvert.IntToByteArrayHex(0, hiscoreData.ShortScore5.Length));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}", 1, ByteArrayToScore(hiscoreData.Score1), ByteArrayToString(hiscoreData.Name1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, ByteArrayToScore(hiscoreData.Score2), ByteArrayToString(hiscoreData.Name2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, ByteArrayToScore(hiscoreData.Score3), ByteArrayToString(hiscoreData.Name3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, ByteArrayToScore(hiscoreData.Score4), ByteArrayToString(hiscoreData.Name4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, ByteArrayToScore(hiscoreData.Score5), ByteArrayToString(hiscoreData.Name5)) + Environment.NewLine;

            return retString;
        }
    }
}


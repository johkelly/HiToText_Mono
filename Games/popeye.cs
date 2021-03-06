using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class popeye : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            public byte LastScoreModified;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] Ranks;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] NameA;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ScoreA;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] NameB;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ScoreB;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] NameC;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ScoreC;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] NameD;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ScoreD;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] NameE;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] ScoreE;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] HiScoreShort;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] HiScoreLong;
        }

        public popeye()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "popeye,popeyeu,popeyef,popeyebl";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0x0a && data[i] <= 0x23)
                    sb.Append(((char)((((int)data[i])) + 65 - 0x0a)));
                else if (data[i] == 0x24)
                    sb.Append('/');
                else if (data[i] == 0x25)
                    sb.Append(',');
                else if (data[i] == 0x26)
                    sb.Append('.');
                else if (data[i] == 0x27)
                    sb.Append('*');
                else if (data[i] == 0x28)
                    sb.Append('▒');
                else if (data[i] == 0x29)
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
                    data[i] = (byte)(((int)str[i] - 65 + 0x0a));
                else if (str[i] == '/')
                    data[i] = 0x24;
                else if (str[i] == ',')
                    data[i] = 0x25;
                else if (str[i] == '.')
                    data[i] = 0x26;
                else if (str[i] == '*')
                    data[i] = 0x27;
                else if (str[i] == '▒')
                    data[i] = 0x28;
                else if (str[i] == ' ')
                    data[i] = 0x29;
            }

            return data;
        }

        public byte[] GetHiScore(int score, int length)
        {
            StringBuilder sb = new StringBuilder();
            String strScore = score.ToString();
            strScore = strScore.PadLeft(length, '0');

            for (int i = 0; i < length; i++)
                sb.Insert(0, "0" + strScore[i].ToString());

            return HiConvert.HexStringToByteArray(sb.ToString());
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE POINTERS
            List<byte[]> Scores = new List<byte[]>();
            List<byte[]> Names = new List<byte[]>();

            byte rankLast;

            for (int i = 0; i < NumEntries; i++)
            {
                int rankPointer = Convert.ToInt32(hiscoreData.Ranks[i]);
                switch (rankPointer)
                {
                    case 0x23:
                        Scores.Add(hiscoreData.ScoreE);
                        Names.Add(hiscoreData.NameE);
                        break;
                    case 0x1d:
                        Scores.Add(hiscoreData.ScoreD);
                        Names.Add(hiscoreData.NameD);
                        break;
                    case 0x17:
                        Scores.Add(hiscoreData.ScoreC);
                        Names.Add(hiscoreData.NameC);
                        break;
                    case 0x11:
                        Scores.Add(hiscoreData.ScoreB);
                        Names.Add(hiscoreData.NameB);
                        break;
                    case 0x0b:
                        Scores.Add(hiscoreData.ScoreA);
                        Names.Add(hiscoreData.NameA);
                        break;
                    default:
                        break;
                }
            }

            #endregion

            #region DETERMINE RANK
            int rank = NumEntries;
            for (int i = 0; i < NumEntries; i++)
            {
                if (score > HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(Scores[i])))
                {
                    rank = i;
                    break;
                }
            }
            rankLast = hiscoreData.Ranks[4];
            #endregion

            #region ADJUST
            int adjust = NumEntries - 1;
            if (rank < NumEntries - 1)
                adjust = NumEntries - 2;
            switch (adjust)
            {
                case 0:
                    hiscoreData.Ranks[1] = hiscoreData.Ranks[0];
                    break;
                case 1:
                    hiscoreData.Ranks[2] = hiscoreData.Ranks[1];
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    hiscoreData.Ranks[3] = hiscoreData.Ranks[2]; 
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    hiscoreData.Ranks[4] = hiscoreData.Ranks[3]; 
                    if (rank < 3)
                        goto case 2;
                    break;
                default:
                    break;
            }
            #endregion

            #region REPLACE_NEW
            if (rank < NumEntries)
            {
                HiConvert.ByteArrayCopy(Names[NumEntries - 1], StringToByteArray(name));
                HiConvert.ByteArrayCopy(Scores[NumEntries - 1], HiConvert.ReverseByteArray(HiConvert.IntToByteArrayHex(score, Scores[NumEntries - 1].Length)));

                hiscoreData.Ranks[rank] = rankLast;

                if (rank == 0)
                {
                    HiConvert.ByteArrayCopy(hiscoreData.HiScoreShort, HiConvert.ReverseByteArray(HiConvert.IntToByteArrayHex(score, hiscoreData.HiScoreShort.Length)));
                    HiConvert.ByteArrayCopy(hiscoreData.HiScoreLong, GetHiScore(score, hiscoreData.HiScoreLong.Length));
                }
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            HiConvert.ByteArrayCopy(hiscoreData.ScoreA, HiConvert.IntToByteArrayHex(0, hiscoreData.ScoreA.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ScoreB, HiConvert.IntToByteArrayHex(0, hiscoreData.ScoreB.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ScoreC, HiConvert.IntToByteArrayHex(0, hiscoreData.ScoreC.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ScoreD, HiConvert.IntToByteArrayHex(0, hiscoreData.ScoreD.Length));
            HiConvert.ByteArrayCopy(hiscoreData.ScoreE, HiConvert.IntToByteArrayHex(0, hiscoreData.ScoreE.Length));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            for (int i = 0; i < NumEntries; i++)
            {
                int rankPointer = Convert.ToInt32(hiscoreData.Ranks[i]);
                switch (rankPointer)
                {
                    case 0x23:
                        retString += String.Format(
                            "{0}|{1}|{2}",
                            i + 1,
                            HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(hiscoreData.ScoreE)),
                            ByteArrayToString(hiscoreData.NameE)) + Environment.NewLine;
                        break;
                    case 0x1d:
                        retString += String.Format(
                            "{0}|{1}|{2}",
                            i + 1,
                            HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(hiscoreData.ScoreD)),
                            ByteArrayToString(hiscoreData.NameD)) + Environment.NewLine;
                        break;
                    case 0x17:
                        retString += String.Format(
                            "{0}|{1}|{2}",
                            i + 1,
                            HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(hiscoreData.ScoreC)),
                            ByteArrayToString(hiscoreData.NameC)) + Environment.NewLine;
                        break;
                    case 0x11:
                        retString += String.Format(
                            "{0}|{1}|{2}",
                            i + 1,
                            HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(hiscoreData.ScoreB)),
                            ByteArrayToString(hiscoreData.NameB)) + Environment.NewLine;
                        break;
                    case 0x0b:
                        retString += String.Format(
                            "{0}|{1}|{2}",
                            i + 1,
                            HiConvert.ByteArrayHexToInt(HiConvert.ReverseByteArray(hiscoreData.ScoreA)),
                            ByteArrayToString(hiscoreData.NameA)) + Environment.NewLine;
                        break;
                    default:
                        break;
                }
            }

            return retString;
        }
    }
}


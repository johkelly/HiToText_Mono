using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class ccastles : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            public byte Header;
            
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] ScoreLast;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] ScoreMid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] ScoreFirst;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] NameFirst;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] NameMid;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 250)]
            public byte[] NameLast;

            public byte Footer;
        }

        public ccastles()
        {
            m_numEntries = 250;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "ccastles,ccastle3,ccastlej,ccastle1,ccastle2,ccastlef,ccastleg,ccastlep";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0x4a && data[i] <= 0x63)
                    sb.Append(((char)((((int)data[i])) + 65 - 0x4a)));
                else if (data[i] == 0x64)
                    sb.Append(' ');
                else if (data[i] == 0x65)
                    sb.Append('☻');
                else if (data[i] == 0x66)
                    sb.Append('/');
                else if (data[i] == 0x67)
                    sb.Append('?');
                else if (data[i] == 0x68)
                    sb.Append(':');
                else if (data[i] == 0x69)
                    sb.Append('→');
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    data[i] = (byte)(((int)str[i] - 65 + 0x4a));
                else if (str[i] == ' ')
                    data[i] = 0x64;
                else if (str[i] == '☻')
                    data[i] = 0x65;
                else if (str[i] == '/')
                    data[i] = 0x66;
                else if (str[i] == '?')
                    data[i] = 0x67;
                else if (str[i] == ':')
                    data[i] = 0x68;
                else if (str[i] == '→')
                    data[i] = 0x69;
            }

            return data;
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            for (int i = 0; i < NumEntries; i++)
            {
                int locForRank = (NumEntries - i) - 1;
                if (score > HiConvert.ByteArrayHexToInt(new byte[] { hiscoreData.ScoreFirst[locForRank], 
                                                                     hiscoreData.ScoreMid[locForRank], 
                                                                     hiscoreData.ScoreLast[locForRank] }))
                {
                    rank = i;
                    break;
                }
            }
            #endregion

            #region ADJUST
            int adjust = -1;
            if (rank < NumEntries - 1)
                adjust = NumEntries - 2;
            for (int i = adjust; i >= 0; i--)
            {
                if (rank > i)
                    break;

                int offsetOldLoc = (NumEntries - 1 - i);
                int offsetNewLoc = (NumEntries - 1 - (i + 1));

                hiscoreData.ScoreFirst[offsetNewLoc] = hiscoreData.ScoreFirst[offsetOldLoc];
                hiscoreData.ScoreMid[offsetNewLoc] = hiscoreData.ScoreMid[offsetOldLoc];
                hiscoreData.ScoreLast[offsetNewLoc] = hiscoreData.ScoreLast[offsetOldLoc];

                hiscoreData.NameFirst[offsetNewLoc] = hiscoreData.NameFirst[offsetOldLoc];
                hiscoreData.NameMid[offsetNewLoc] = hiscoreData.NameMid[offsetOldLoc];
                hiscoreData.NameLast[offsetNewLoc] = hiscoreData.NameLast[offsetOldLoc];
            }
            #endregion

            #region REPLACE_NEW
            if (rank < NumEntries)
            {
                byte[] scoreAsByteArray = HiConvert.IntToByteArrayHex(score, 3);
                byte[] nameAsByteArray = StringToByteArray(name);

                int offset = (NumEntries - rank) - 1;

                hiscoreData.ScoreFirst[offset] = scoreAsByteArray[0];
                hiscoreData.ScoreMid[offset] = scoreAsByteArray[1];
                hiscoreData.ScoreLast[offset] = scoreAsByteArray[2];

                hiscoreData.NameFirst[offset] = nameAsByteArray[0];
                hiscoreData.NameMid[offset] = nameAsByteArray[1];
                hiscoreData.NameLast[offset] = nameAsByteArray[2];
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            for (int i = 0; i < NumEntries; i++)
            {
                hiscoreData.ScoreFirst[i] = 0x00;
                hiscoreData.ScoreMid[i] = 0x00;
                hiscoreData.ScoreLast[i] = 0x00;
            }

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            for (int i = NumEntries - 1; i >= 0; i--)
            {
                retString += String.Format("{0}|{1}|{2}",
                    NumEntries - i,
                    HiConvert.ByteArrayHexToInt(new byte[] { hiscoreData.ScoreFirst[i], hiscoreData.ScoreMid[i], hiscoreData.ScoreLast[i] }),
                    ByteArrayToString(new byte[] { hiscoreData.NameFirst[i], hiscoreData.NameMid[i], hiscoreData.NameLast[i] })) + Environment.NewLine;
            }
            
            return retString;
        }
    }
}
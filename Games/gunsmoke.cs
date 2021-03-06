using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class gunsmoke : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            public byte Score1Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Name1Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name1;

            public byte Score2Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Name2Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name2;

            public byte Score3Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Name3Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name3;

            public byte Score4Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Name4Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name4;

            public byte Score5Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Name5Unused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name5;

            public byte HiScoreUnused;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
            public byte[] HiScore;
        }

        public gunsmoke()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "gunsmoke,gunsmrom,gunsmoka,gunsmoku";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < data.Length; i = i + 2)
            {
                if (data[i] >= 0x0a && data[i] <= 0x23)
                    sb.Append(((char)((((int)data[i])) + 65 - 0x0a)));
                else if (data[i] == 0x00)
                    sb.Append('0');
                else if (data[i] == 0x01)
                    sb.Append('1');
                else if (data[i] == 0x02)
                    sb.Append('2');
                else if (data[i] == 0x03)
                    sb.Append('3');
                else if (data[i] == 0x04)
                    sb.Append('4');
                else if (data[i] == 0x05)
                    sb.Append('5');
                else if (data[i] == 0x06)
                    sb.Append('6');
                else if (data[i] == 0x07)
                    sb.Append('7');
                else if (data[i] == 0x08)
                    sb.Append('8');
                else if (data[i] == 0x09)
                    sb.Append('9');
                else if (data[i] == 0x24)
                    sb.Append(' ');
                else if (data[i] == 0x2e)
                    sb.Append('*');
                else if (data[i] == 0x2f)
                    sb.Append('#');
                else if (data[i] == 0x34) 
                    sb.Append('♂');
                else if (data[i] == 0x35) 
                    sb.Append('♀');
                else if (data[i] == 0x3e) 
                    sb.Append('☎');
                else if (data[i] == 0x48) 
                    sb.Append('♪');
                else if (data[i] == 0x49) 
                    sb.Append('♫');
                else if (data[i] == 0x60) 
                    sb.Append('♦');
                else if (data[i] == 0x61) 
                    sb.Append('♠');
                else if (data[i] == 0x62) 
                    sb.Append('♡');
                else if (data[i] == 0x63) 
                    sb.Append('♥');
                else if (data[i] == 0x64) 
                    sb.Append('☆');
                else if (data[i] == 0x65) 
                    sb.Append('★');
                else if (data[i] == 0x68)
                    sb.Append('?');
                //For the below I could not find accurate symbols, if someone has ideas, I'm all for using them.
                else if (data[i] == 0x40) //male in red shirt
                    sb.Append('a');
                else if (data[i] == 0x41) //girl in red dress
                    sb.Append('b');
                else if (data[i] == 0x43) //red dinosaur?
                    sb.Append('c');
                else if (data[i] == 0x45) //sailboat red sail
                    sb.Append('d');
                else if (data[i] == 0x4a) //red car side
                    sb.Append('e');
                else if (data[i] == 0x4e) //red car front
                    sb.Append('f');
                else if (data[i] == 0x5b) //japanese flag
                    sb.Append('g');
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length * 2];

            for (int i = 0; i < str.Length; i++)
            {
                data[i * 2] = 0x24;
                if (str[i] >= 'A' && str[i] <= 'Z')
                    data[(i * 2) + 1] = (byte)(((int)str[i] - 65 + 0x0a));
                else if (str[i] == '0')
                    data[(i * 2) + 1] = 0x00;
                else if (str[i] == '1')
                    data[(i * 2) + 1] = 0x01;
                else if (str[i] == '2')
                    data[(i * 2) + 1] = 0x02;
                else if (str[i] == '3')
                    data[(i * 2) + 1] = 0x03;
                else if (str[i] == '4')
                    data[(i * 2) + 1] = 0x04;
                else if (str[i] == '5')
                    data[(i * 2) + 1] = 0x05;
                else if (str[i] == '6')
                    data[(i * 2) + 1] = 0x06;
                else if (str[i] == '7')
                    data[(i * 2) + 1] = 0x07;
                else if (str[i] == '8')
                    data[(i * 2) + 1] = 0x08;
                else if (str[i] == '9')
                    data[(i * 2) + 1] = 0x09;
                else if (str[i] == ' ')
                    data[(i * 2) + 1] = 0x24;
                else if (str[i] == '*')
                    data[(i * 2) + 1] = 0x2e;
                else if (str[i] == '#')
                    data[(i * 2) + 1] = 0x2f;
                else if (str[i] == '♂')
                    data[(i * 2) + 1] = 0x34; 
                else if (str[i] == '♀')
                    data[(i * 2) + 1] = 0x35; 
                else if (str[i] == '☎')
                    data[(i * 2) + 1] = 0x3e; 
                else if (str[i] == '♪')
                    data[(i * 2) + 1] = 0x48; 
                else if (str[i] == '♫')
                    data[(i * 2) + 1] = 0x49; 
                else if (str[i] == '♦')
                    data[(i * 2) + 1] = 0x60;
                else if (str[i] == '♠')
                    data[(i * 2) + 1] = 0x61; 
                else if (str[i] == '♡')
                    data[(i * 2) + 1] = 0x62; 
                else if (str[i] == '♥')
                    data[(i * 2) + 1] = 0x63; 
                else if (str[i] == '☆')
                    data[(i * 2) + 1] = 0x64; 
                else if (str[i] == '★')
                    data[(i * 2) + 1] = 0x65;
                else if (str[i] == '?')
                    data[(i * 2) + 1] = 0x68;
                //For the below I could not find accurate symbols, if someone has ideas, I'm all for using them.
                else if (str[i] == 'a') //male in red shirt
                    data[(i * 2) + 1] = 0x40;
                else if (str[i] == 'b') //girl in red dress
                    data[(i * 2) + 1] = 0x41;
                else if (str[i] == 'c') //red dinosaur?
                    data[(i * 2) + 1] = 0x43;
                else if (str[i] == 'd') //sailboat red sail
                    data[(i * 2) + 1] = 0x45;
                else if (str[i] == 'e') //red car side
                    data[(i * 2) + 1] = 0x4a;
                else if (str[i] == 'f') //red car front
                    data[(i * 2) + 1] = 0x4e;
                else if (str[i] == 'g') //japanese flag
                    data[(i * 2) + 1] = 0x5b;
            }

            return data;
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]) / 10;
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            if (score > HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score1))
                rank = 0;
            else if (score > HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score2))
                rank = 1;
            else if (score > HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score3))
                rank = 2;
            else if (score > HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score4))
                rank = 3;
            else if (score > HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score5))
                rank = 4;
            #endregion

            #region ADJUST
            int adjust = NumEntries - 1;
            if (rank < NumEntries - 1)
                adjust = NumEntries - 2;
            switch (adjust)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, hiscoreData.Score1);
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, hiscoreData.Name1);
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, hiscoreData.Score2);
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, hiscoreData.Score3);
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, hiscoreData.Score4);
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
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.Score1.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.HiScore, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.HiScore.Length));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.Score2.Length));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.Score3.Length));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.Score4.Length));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArraySingleBCD(score, hiscoreData.Score5.Length));
                    break;
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            
            HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArraySingleBCD(0, 7));
            HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArraySingleBCD(0, 7));
            HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArraySingleBCD(0, 7));
            HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArraySingleBCD(0, 7));
            HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArraySingleBCD(0, 7));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}", 1, HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score1) * 10, ByteArrayToString(hiscoreData.Name1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score2) * 10, ByteArrayToString(hiscoreData.Name2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score3) * 10, ByteArrayToString(hiscoreData.Name3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score4) * 10, ByteArrayToString(hiscoreData.Name4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, HiConvert.ByteArraySingleBCDToInt(hiscoreData.Score5) * 10, ByteArrayToString(hiscoreData.Name5)) + Environment.NewLine;

            return retString;
        }
    }
}


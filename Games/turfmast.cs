using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class turfmast : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x324)]
            public byte[] NotInteresting1; 

            public sbyte Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;            
            public byte Course1;

            public sbyte Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Course2;
                        
            public sbyte Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Course3;

            public sbyte Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            public byte Course4;

            public sbyte Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            public byte Course5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x1cc3)]
            public byte[] NotInteresting2; 
        }

        public turfmast()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME|COURSE";
            m_gamesSupported = "turfmast";
            m_extensionsRequired = ".nv";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                // Letters
                if (data[i] >= 0x00 && data[i] <= 0x0e)
                    sb.Append((char)(((int)data[i] / 2) + 65));
                else if (data[i] >= 0x20 && data[i] <= 0x2e)
                    sb.Append((char)(((int)data[i] / 2) + 57));
                else if (data[i] >= 0x40 && data[i] <= 0x4e)
                    sb.Append((char)(((int)data[i] / 2) + 49));
                else if (data[i] >= 0x60 && data[i] <= 0x62)
                    sb.Append((char)(((int)data[i] / 2) + 41));
                // Numbers
                else if (data[i] >= 0x64 && data[i] <= 0x6e) 
                    sb.Append((char)(((int)data[i] / 2) - 1));
                else if (data[i] >= 0x80 && data[i] <= 0x85) 
                    sb.Append((char)(((int)data[i] / 2) -9));
                else if (data[i] == 0x86)
                    sb.Append('0');
                // Symbols
                else if (data[i] == 0x88)
                    sb.Append('!');
                else if (data[i] == 0x8a)
                    sb.Append('?');
                else if (data[i] == 0x8c)
                    sb.Append('$');
                else if (data[i] == 0xe6)
                    sb.Append(' ');
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                // Letters
                if (str[i] >= 'A' && str[i] <= 'H')
                    data[i] = (byte)(((int)str[i] - 65) * 2);
                else if (str[i] >= 'I' && str[i] <= 'P')
                    data[i] = (byte)(((int)str[i] - 57) * 2);
                else if (str[i] >= 'Q' && str[i] <= 'X')
                    data[i] = (byte)(((int)str[i] - 49) * 2);
                else if (str[i] >= 'Y' && str[i] <= 'Z')
                    data[i] = (byte)(((int)str[i] - 41) * 2);
                // Numbers
                else if (str[i] >= '1' && str[i] <= '6')
                    data[i] = (byte)(((int)str[i] - 24) * 2);
                else if (str[i] >= '7' && str[i] <= '9')
                    data[i] = (byte)(((int)str[i] + 9) * 2);
                else if (str[i] == '0')
                    data[i] = 0x86;
                // Symbols
                else if (str[i] == '!')
                    data[i] = 0x88;
                else if (str[i] == '?')
                    data[i] = 0x8a;
                else if (str[i] == '$')
                    data[i] = 0x8c;
                else if (str[i] == ' ')
                    data[i] = 0xe6;                    
            }

            return data;
        }

        public string SByteScoreToString(sbyte data)
        {
            string strdata;

            if (data == 0x00)
                strdata = "EVEN";
            else if (data > 0x00)
                strdata = "+" + data.ToString();
            else strdata = data.ToString();
            
            return strdata;
        }

        public sbyte StringScoreToSByte(string str)
        {
            if (str == "EVEN")
                return 0;
            return Convert.ToSByte(str);
        }

        public string ByteCourseToString(byte data)
        {
            switch (data)
            {
                case 0:
                    return "G.CANYON";
                case 1:
                    return "WOODY";
                case 2:
                    return "FUJIYAMA";
                case 3:
                    return "SEASIDE";
                default:
                    return "G.CANYON";
            }
        }

        public byte StringCourseToByte(string str)
        {
            switch (str)
            {
                case "G.CANYON":
                    return 0;
                case "WOODY":
                    return 1;
                case "FUJIYAMA":
                    return 2;
                case "SEASIDE":
                    return 3;
                default:
                    return 0;
            }
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            sbyte score = StringScoreToSByte(args[1]);
            string name = args[2].ToUpper();
            byte course = StringCourseToByte(args[3].ToUpper());

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(HiConvert.ByteSwapArray(m_data), 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries; // In this case, lower scores are better
            if (score < hiscoreData.Score1)
                rank = 0;
            else if (score < hiscoreData.Score2)
                rank = 1;
            else if (score < hiscoreData.Score3)
                rank = 2;
            else if (score < hiscoreData.Score4)
                rank = 3;
            else if (score < hiscoreData.Score5)
                rank = 4;
            #endregion

            #region ADJUST
            int adjust = NumEntries - 1;
            if (rank < NumEntries - 1)
                adjust = NumEntries - 2;
            switch (adjust)
            {
                case 0:
                    hiscoreData.Score2 = hiscoreData.Score1;
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, hiscoreData.Name1);
                    hiscoreData.Course2 = hiscoreData.Course1;
                    break;
                case 1:
                    hiscoreData.Score3 = hiscoreData.Score2;
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    hiscoreData.Course3 = hiscoreData.Course2;
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    hiscoreData.Score4 = hiscoreData.Score3;
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    hiscoreData.Course4 = hiscoreData.Course3;
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    hiscoreData.Score5 = hiscoreData.Score4;
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, hiscoreData.Name4);
                    hiscoreData.Course5 = hiscoreData.Course4;
                    if (rank < 3)
                        goto case 2;
                    break;                
            }
            #endregion

            #region REPLACE_NEW
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Name1, StringToByteArray(name));
                    hiscoreData.Score1 = score;
                    hiscoreData.Course1 = course;                  
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    hiscoreData.Score2 = score;
                    hiscoreData.Course2 = course;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    hiscoreData.Score3 = score;
                    hiscoreData.Course3 = course;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    hiscoreData.Score4 = score;
                    hiscoreData.Course4 = course;
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    hiscoreData.Score5 = score;
                    hiscoreData.Course5 = course;
                    break;               
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, HiConvert.ByteSwapArray(byteArray));
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(HiConvert.ByteSwapArray(m_data), 0, typeof(HiscoreData));

            hiscoreData.Score1 = 0;
            hiscoreData.Score2 = 0;
            hiscoreData.Score3 = 0;
            hiscoreData.Score4 = 0;
            hiscoreData.Score5 = 0;
         
            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, HiConvert.ByteSwapArray(byteArray));

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();            
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(HiConvert.ByteSwapArray(m_data), 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}|{3}", 1, SByteScoreToString(hiscoreData.Score1), ByteArrayToString(hiscoreData.Name1), ByteCourseToString(hiscoreData.Course1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}", 2, SByteScoreToString(hiscoreData.Score2), ByteArrayToString(hiscoreData.Name2), ByteCourseToString(hiscoreData.Course2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}", 3, SByteScoreToString(hiscoreData.Score3), ByteArrayToString(hiscoreData.Name3), ByteCourseToString(hiscoreData.Course3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}", 4, SByteScoreToString(hiscoreData.Score4), ByteArrayToString(hiscoreData.Name4), ByteCourseToString(hiscoreData.Course4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}", 5, SByteScoreToString(hiscoreData.Score5), ByteArrayToString(hiscoreData.Name5), ByteCourseToString(hiscoreData.Course5)) + Environment.NewLine;

            return retString;
        }
    }
}
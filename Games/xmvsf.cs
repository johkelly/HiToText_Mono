using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class xmvsf : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] SeparatorA1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte SeparatorB1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] SeparatorA2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte SeparatorB2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] SeparatorA3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte SeparatorB3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] SeparatorA4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            public byte SeparatorB4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] SeparatorA5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            public byte SeparatorB5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VWins1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VUnknown1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VSeparatorA1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] VName1;
            public byte VSeparatorB1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VWins2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VUnknown2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VSeparatorA2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] VName2;
            public byte VSeparatorB2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VWins3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VUnknown3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VSeparatorA3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] VName3;
            public byte VSeparatorB3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VWins4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VUnknown4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VSeparatorA4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] VName4;
            public byte VSeparatorB4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VWins5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VUnknown5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] VSeparatorA5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] VName5;
        }

        public xmvsf()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME";
            m_altFormat = new string[] { "VERSUS HIGH SCORE" + Environment.NewLine + "RANK|WINS|NAME" };
            m_numAltEntries = new int[] { 5 };
            m_gamesSupported = "xmvsf,xmvsfur1,xmvsfu,xmvsfar1,xmvsfa,xmvsfb,xmvsfr1,xmvsfh,xmvsfjr2,xmvsfjr1,xmvsfj,xmvsfu1d";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0x00 && data[i] <= 0x19)
                    sb.Append(((char)((((int)data[i])) + 65)));
                else if (data[i] == 0x1a)
                    sb.Append('0');
                else if (data[i] == 0x1b)
                    sb.Append('1');
                else if (data[i] == 0x1c)
                    sb.Append('2');
                else if (data[i] == 0x1d)
                    sb.Append('3');
                else if (data[i] == 0x1e)
                    sb.Append('4');
                else if (data[i] == 0x1f)
                    sb.Append('5');
                else if (data[i] == 0x20)
                    sb.Append('6');
                else if (data[i] == 0x21)
                    sb.Append('7');
                else if (data[i] == 0x22)
                    sb.Append('8');
                else if (data[i] == 0x23)
                    sb.Append('9');
                else if (data[i] == 0x24)
                    sb.Append('!');
                else if (data[i] == 0x25)
                    sb.Append('&');
                else if (data[i] == 0x26)
                    sb.Append('-');
                else if (data[i] == 0x27)
                    sb.Append('.');
                else if (data[i] == 0x28)
                    sb.Append('/');
                else if (data[i] == 0x29)
                    sb.Append('♥');
                else if (data[i] == 0x2a)
                    sb.Append('?');
                else if (data[i] == 0x2b)
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
                    data[i] = (byte)(((int)str[i] - 65));
                else if (str[i] == '0')
                    data[i] = 0x1a;
                else if (str[i] == '1')
                    data[i] = 0x1b;
                else if (str[i] == '2')
                    data[i] = 0x1c;
                else if (str[i] == '3')
                    data[i] = 0x1d;
                else if (str[i] == '4')
                    data[i] = 0x1e;
                else if (str[i] == '5')
                    data[i] = 0x1f;
                else if (str[i] == '6')
                    data[i] = 0x20;
                else if (str[i] == '7')
                    data[i] = 0x21;
                else if (str[i] == '8')
                    data[i] = 0x22;
                else if (str[i] == '9')
                    data[i] = 0x23;
                else if (str[i] == '!')
                    data[i] = 0x24;
                else if (str[i] == '&')
                    data[i] = 0x25;
                else if (str[i] == '-')
                    data[i] = 0x26;
                else if (str[i] == '.')
                    data[i] = 0x27;
                else if (str[i] == '/')
                    data[i] = 0x28;
                else if (str[i] == '♥')
                    data[i] = 0x29;
                else if (str[i] == '?')
                    data[i] = 0x2a;
                else if (str[i] == ' ')
                    data[i] = 0x2b;
            }

            return data;
        }

        private int GetAlternateName(string altName)
        {
            switch (altName)
            {
                case "VERSUS HIGH SCORE":
                    return 0;
            }
            return -1;
        }

        private int GetWins(string wins)
        {
            return Convert.ToInt32(wins.Substring(0, wins.IndexOf(" WINS")));
        }

        private string GetWins(int wins)
        {
            return wins.ToString() + " WINS";
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score1))
                rank = 0;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score2))
                rank = 1;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score3))
                rank = 2;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score4))
                rank = 3;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score5))
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
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArrayHex(score, hiscoreData.Score1.Length));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArrayHex(score, hiscoreData.Score2.Length));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArrayHex(score, hiscoreData.Score3.Length));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArrayHex(score, hiscoreData.Score4.Length));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArrayHex(score, hiscoreData.Score5.Length));
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
            int wins = GetWins(args[2]);
            string name = args[3];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumAltEntries[alternateName];
            if (wins > HiConvert.ByteArrayHexToInt(hiscoreData.VWins1))
                rank = 0;
            else if (wins > HiConvert.ByteArrayHexToInt(hiscoreData.VWins2))
                rank = 1;
            else if (wins > HiConvert.ByteArrayHexToInt(hiscoreData.VWins3))
                rank = 2;
            else if (wins > HiConvert.ByteArrayHexToInt(hiscoreData.VWins4))
                rank = 3;
            else if (wins > HiConvert.ByteArrayHexToInt(hiscoreData.VWins5))
                rank = 4;
            #endregion

            #region ADJUST
            int adjust = NumAltEntries[alternateName] - 1;
            if (rank < NumAltEntries[alternateName] - 1)
                adjust = NumAltEntries[alternateName] - 2;

            switch (adjust)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.VWins2, hiscoreData.VWins1);
                    HiConvert.ByteArrayCopy(hiscoreData.VName2, hiscoreData.VName1);
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.VWins3, hiscoreData.VWins2);
                    HiConvert.ByteArrayCopy(hiscoreData.VName3, hiscoreData.VName2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.VWins4, hiscoreData.VWins3);
                    HiConvert.ByteArrayCopy(hiscoreData.VName4, hiscoreData.VName3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.VWins5, hiscoreData.VWins4);
                    HiConvert.ByteArrayCopy(hiscoreData.VName5, hiscoreData.VName4);
                    if (rank < 3)
                        goto case 2;
                    break;
            }
            #endregion

            #region REPLACE_NEW
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.VName1, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.VWins1, HiConvert.IntToByteArrayHex(wins, hiscoreData.VWins1.Length));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.VName2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.VWins2, HiConvert.IntToByteArrayHex(wins, hiscoreData.VWins2.Length));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.VName3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.VWins3, HiConvert.IntToByteArrayHex(wins, hiscoreData.VWins3.Length));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.VName4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.VWins4, HiConvert.IntToByteArrayHex(wins, hiscoreData.VWins4.Length));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.VName5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.VWins5, HiConvert.IntToByteArrayHex(wins, hiscoreData.VWins5.Length));
                    break;
            }
            #endregion

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);
        }

        public override void EmptyScores()
        {
            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));
            HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArrayHex(0, hiscoreData.Score1.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArrayHex(0, hiscoreData.Score2.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArrayHex(0, hiscoreData.Score3.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArrayHex(0, hiscoreData.Score4.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArrayHex(0, hiscoreData.Score5.Length));
            HiConvert.ByteArrayCopy(hiscoreData.VWins1, HiConvert.IntToByteArrayHex(0, hiscoreData.VWins1.Length));
            HiConvert.ByteArrayCopy(hiscoreData.VWins2, HiConvert.IntToByteArrayHex(0, hiscoreData.VWins2.Length));
            HiConvert.ByteArrayCopy(hiscoreData.VWins3, HiConvert.IntToByteArrayHex(0, hiscoreData.VWins3.Length));
            HiConvert.ByteArrayCopy(hiscoreData.VWins4, HiConvert.IntToByteArrayHex(0, hiscoreData.VWins4.Length));
            HiConvert.ByteArrayCopy(hiscoreData.VWins5, HiConvert.IntToByteArrayHex(0, hiscoreData.VWins5.Length));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = Format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}", 1, HiConvert.ByteArrayHexToInt(hiscoreData.Score1), ByteArrayToString(hiscoreData.Name1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, HiConvert.ByteArrayHexToInt(hiscoreData.Score2), ByteArrayToString(hiscoreData.Name2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, HiConvert.ByteArrayHexToInt(hiscoreData.Score3), ByteArrayToString(hiscoreData.Name3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, HiConvert.ByteArrayHexToInt(hiscoreData.Score4), ByteArrayToString(hiscoreData.Name4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, HiConvert.ByteArrayHexToInt(hiscoreData.Score5), ByteArrayToString(hiscoreData.Name5)) + Environment.NewLine;

            retString += Environment.NewLine + Environment.NewLine + AltFormat[0] + Environment.NewLine;

            retString += String.Format("{0}|{1}|{2}", 1, GetWins(HiConvert.ByteArrayHexToInt(hiscoreData.VWins1)), ByteArrayToString(hiscoreData.VName1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, GetWins(HiConvert.ByteArrayHexToInt(hiscoreData.VWins2)), ByteArrayToString(hiscoreData.VName2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, GetWins(HiConvert.ByteArrayHexToInt(hiscoreData.VWins3)), ByteArrayToString(hiscoreData.VName3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, GetWins(HiConvert.ByteArrayHexToInt(hiscoreData.VWins4)), ByteArrayToString(hiscoreData.VName4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, GetWins(HiConvert.ByteArrayHexToInt(hiscoreData.VWins5)), ByteArrayToString(hiscoreData.VName5)) + Environment.NewLine;

            return retString;
        }
    }
}
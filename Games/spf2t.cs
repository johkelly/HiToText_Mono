using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class spf2t : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte Seperator1;
            public byte Character1;
            public byte UnknownA1;
            public byte UnknownB1;
            public byte Level1;
            public byte MaxChain1;
            public byte MaxPowerGem1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Footer1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Seperator2;
            public byte Character2;
            public byte UnknownA2;
            public byte UnknownB2;
            public byte Level2;
            public byte MaxChain2;
            public byte MaxPowerGem2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Footer2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Seperator3;
            public byte Character3;
            public byte UnknownA3;
            public byte UnknownB3;
            public byte Level3;
            public byte MaxChain3;
            public byte MaxPowerGem3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Footer3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            public byte Seperator4;
            public byte Character4;
            public byte UnknownA4;
            public byte UnknownB4;
            public byte Level4;
            public byte MaxChain4;
            public byte MaxPowerGem4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Footer4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            public byte Seperator5;
            public byte Character5;
            public byte UnknownA5;
            public byte UnknownB5;
            public byte Level5;
            public byte MaxChain5;
            public byte MaxPowerGem5;

            public byte FinalFooter;
        }

        public spf2t()
        {
            m_numEntries = 5;
            m_format = "RANK|SCORE|NAME|CHARACTER|LEVEL|MAX CHAIN|MAX POWER GEM";
            m_gamesSupported = "spf2t,spf2xj,spf2xjd,spf2ta";
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
                    sb.Append('?');
                else if (data[i] == 0x26)
                    sb.Append('.');
                else if (data[i] == 0x27)
                    sb.Append('-');
                else if (data[i] == 0x28)
                    sb.Append(',');
                else if (data[i] == 0x29)
                    sb.Append('♥');
                else if (data[i] == 0x2a)
                    sb.Append('←');
                else if (data[i] == 0x2b)
                    sb.Append('&');
                else if (data[i] == 0x2c)
                    sb.Append('=');
                else if (data[i] == 0x2d)
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
                else if (str[i] == '?')
                    data[i] = 0x25;
                else if (str[i] == '.')
                    data[i] = 0x26;
                else if (str[i] == '-')
                    data[i] = 0x27;
                else if (str[i] == ',')
                    data[i] = 0x28;
                else if (str[i] == '♥')
                    data[i] = 0x29;
                else if (str[i] == '←')
                    data[i] = 0x2a;
                else if (str[i] == '&')
                    data[i] = 0x2b;
                else if (str[i] == '=')
                    data[i] = 0x2c;
                else if (str[i] == ' ')
                    data[i] = 0x2d;
            }

            return data;
        }

        private int GetLevel(string level)
        {
            switch (level)
            {
                case "EASY":
                    return 0;
                case "NORMAL":
                    return 1;
                case "HARD":
                    return 2;
            }
            return -1;
        }

        private String GetLevel(int level)
        {
            switch (level)
            {
                case 0:
                    return "EASY";
                case 1:
                    return "NORMAL";
                case 2:
                    return "HARD";
            }
            return "";
        }

        private int GetCharacter(string character)
        {
            switch (character)
            {
                case "MORRIGAN":
                    return 0;
                case "CHUN-LI":
                    return 1;
                case "RYU":
                    return 2;
                case "KEN":
                    return 3;
                case "HSIEN-KO":
                    return 4;
                case "DONOVAN":
                    return 5;
                case "FELICIA":
                    return 6;
                case "SAKURA":
                    return 7;
                case "DEVILOT":
                    return 8;
                case "AKUMA":
                    return 9;
                case "DAN":
                    return 10;
            }
            return -1;
        }

        private String GetCharacter(int character)
        {
            switch (character)
            {
                case 0:
                    return "MORRIGAN";
                case 1:
                    return "CHUN-LI";
                case 2:
                    return "RYU";
                case 3:
                    return "KEN";
                case 4:
                    return "HSIEN-KO";
                case 5:
                    return "DONOVAN";
                case 6:
                    return "FELICIA";
                case 7:
                    return "SAKURA";
                case 8:
                    return "DEVILOT";
                case 9:
                    return "AKUMA";
                case 10:
                    return "DAN";
            }
            return "";
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = Convert.ToInt32(args[1]);
            string name = args[2];
            int character = GetCharacter(args[3]);
            int level = GetLevel(args[4]);
            int maxChain = Convert.ToInt32(args[5]);
            int maxPowerGem = Convert.ToInt32(args[6]);

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            if (score > HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score1))
                rank = 0;
            else if (score > HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score2))
                rank = 1;
            else if (score > HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score3))
                rank = 2;
            else if (score > HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score4))
                rank = 3;
            else if (score > HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score5))
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
                    hiscoreData.Character2 = hiscoreData.Character1;
                    hiscoreData.Level2 = hiscoreData.Level1;
                    hiscoreData.MaxChain2 = hiscoreData.MaxChain1;
                    hiscoreData.MaxPowerGem2 = hiscoreData.MaxPowerGem1;
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, hiscoreData.Score2);
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    hiscoreData.Character3 = hiscoreData.Character2;
                    hiscoreData.Level3 = hiscoreData.Level2;
                    hiscoreData.MaxChain3 = hiscoreData.MaxChain2;
                    hiscoreData.MaxPowerGem3 = hiscoreData.MaxPowerGem2;
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, hiscoreData.Score3);
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    hiscoreData.Character4 = hiscoreData.Character3;
                    hiscoreData.Level4 = hiscoreData.Level3;
                    hiscoreData.MaxChain4 = hiscoreData.MaxChain3;
                    hiscoreData.MaxPowerGem4 = hiscoreData.MaxPowerGem3;
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, hiscoreData.Score4);
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, hiscoreData.Name4);
                    hiscoreData.Character5 = hiscoreData.Character4;
                    hiscoreData.Level5 = hiscoreData.Level4;
                    hiscoreData.MaxChain5 = hiscoreData.MaxChain4;
                    hiscoreData.MaxPowerGem5 = hiscoreData.MaxPowerGem4;
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
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArrayHexAsHex(score, hiscoreData.Score1.Length));
                    hiscoreData.Character1 = (byte)character;
                    hiscoreData.Level1 = (byte)level;
                    hiscoreData.MaxChain1 = (byte)maxChain;
                    hiscoreData.MaxPowerGem1 = (byte)maxPowerGem;
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArrayHexAsHex(score, hiscoreData.Score2.Length));
                    hiscoreData.Character2 = (byte)character;
                    hiscoreData.Level2 = (byte)level;
                    hiscoreData.MaxChain2 = (byte)maxChain;
                    hiscoreData.MaxPowerGem2 = (byte)maxPowerGem;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArrayHexAsHex(score, hiscoreData.Score3.Length));
                    hiscoreData.Character3 = (byte)character;
                    hiscoreData.Level3 = (byte)level;
                    hiscoreData.MaxChain3 = (byte)maxChain;
                    hiscoreData.MaxPowerGem3 = (byte)maxPowerGem;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArrayHexAsHex(score, hiscoreData.Score4.Length));
                    hiscoreData.Character4 = (byte)character;
                    hiscoreData.Level4 = (byte)level;
                    hiscoreData.MaxChain4 = (byte)maxChain;
                    hiscoreData.MaxPowerGem4 = (byte)maxPowerGem;
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArrayHexAsHex(score, hiscoreData.Score5.Length));
                    hiscoreData.Character5 = (byte)character;
                    hiscoreData.Level5 = (byte)level;
                    hiscoreData.MaxChain5 = (byte)maxChain;
                    hiscoreData.MaxPowerGem5 = (byte)maxPowerGem;
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

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = Format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", 1, HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score1), ByteArrayToString(hiscoreData.Name1), GetCharacter((int)hiscoreData.Character1), GetLevel((int)hiscoreData.Level1), hiscoreData.MaxChain1, hiscoreData.MaxPowerGem1) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", 2, HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score2), ByteArrayToString(hiscoreData.Name2), GetCharacter((int)hiscoreData.Character2), GetLevel((int)hiscoreData.Level2), hiscoreData.MaxChain2, hiscoreData.MaxPowerGem2) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", 3, HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score3), ByteArrayToString(hiscoreData.Name3), GetCharacter((int)hiscoreData.Character3), GetLevel((int)hiscoreData.Level3), hiscoreData.MaxChain3, hiscoreData.MaxPowerGem3) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", 4, HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score4), ByteArrayToString(hiscoreData.Name4), GetCharacter((int)hiscoreData.Character4), GetLevel((int)hiscoreData.Level4), hiscoreData.MaxChain4, hiscoreData.MaxPowerGem4) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", 5, HiConvert.ByteArrayHexAsHexToInt(hiscoreData.Score5), ByteArrayToString(hiscoreData.Name5), GetCharacter((int)hiscoreData.Character5), GetLevel((int)hiscoreData.Level5), hiscoreData.MaxChain5, hiscoreData.MaxPowerGem5) + Environment.NewLine;
            
            return retString;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class mrdo : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            public byte Scene1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time1;
            public byte Unknown1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            public byte Scene2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time2;
            public byte Unknown2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            public byte Scene3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time3;
            public byte Unknown3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            public byte Scene4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time4;
            public byte Unknown4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            public byte Scene5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time5;
            public byte Unknown5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name6;
            public byte Scene6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time6;
            public byte Unknown6;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name7;
            public byte Scene7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time7;
            public byte Unknown7;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name8;
            public byte Scene8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time8;
            public byte Unknown8;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name9;
            public byte Scene9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time9;
            public byte Unknown9;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Score10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name10;
            public byte Scene10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Time10;
            public byte Unknown10;
        }

        public mrdo()
        {
            m_numEntries = 10;
            m_format = "RANK|SCORE|NAME|SCENE|TIME";
            m_gamesSupported = "mrdo,mrdot,mrdofix,mrlo,mrdu,mrdoy,yankeedo";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= 0x0a && data[i] <= 0x23)
                    sb.Append(((char)(((int)data[i]) + 65 - 0x0a)));
                else if (data[i] == 0x29)
                    sb.Append(' ');
                else if (data[i] == 0x25)
                    sb.Append('!');
                else if (data[i] == 0x26)
                    sb.Append('&');
                else if (data[i] == 0x24)
                    sb.Append('?');
                else if (data[i] == 0x28)
                    sb.Append('.');
                else if (data[i] == 0x27)
                    sb.Append('♥');
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                    data[i] = (byte)((int)str[i] - 65 + 0x0a);
                else if (str[i] == '&')
                    data[i] = 0x26;
                else if (str[i] == '!')
                    data[i] = 0x25;
                else if (str[i] == '?')
                    data[i] = 0x24;
                else if (str[i] == '.')
                    data[i] = 0x28;
                else if (str[i] == '♥')
                    data[i] = 0x27;
                else if (str[i] == ' ')
                    data[i] = 0x29;
            }

            return data;
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]);
            string name = args[2];
            int scene = System.Convert.ToInt32(args[3]);
            int time = System.Convert.ToInt32(args[4]);

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
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score6))
                rank = 5;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score7))
                rank = 6;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score8))
                rank = 7;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score9))
                rank = 8;
            else if (score > HiConvert.ByteArrayHexToInt(hiscoreData.Score10))
                rank = 9;
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
                    hiscoreData.Scene2 = hiscoreData.Scene1;
                    HiConvert.ByteArrayCopy(hiscoreData.Time2, hiscoreData.Time1);
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, hiscoreData.Score2);
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    hiscoreData.Scene3 = hiscoreData.Scene2;
                    HiConvert.ByteArrayCopy(hiscoreData.Time3, hiscoreData.Time2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, hiscoreData.Score3);
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    hiscoreData.Scene4 = hiscoreData.Scene3;
                    HiConvert.ByteArrayCopy(hiscoreData.Time4, hiscoreData.Time3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, hiscoreData.Score4);
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, hiscoreData.Name4);
                    hiscoreData.Scene5 = hiscoreData.Scene4;
                    HiConvert.ByteArrayCopy(hiscoreData.Time5, hiscoreData.Time4);
                    if (rank < 3)
                        goto case 2;
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, hiscoreData.Score5);
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, hiscoreData.Name5);
                    hiscoreData.Scene6 = hiscoreData.Scene5;
                    HiConvert.ByteArrayCopy(hiscoreData.Time6, hiscoreData.Time5);
                    if (rank < 4)
                        goto case 3;
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, hiscoreData.Score6);
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, hiscoreData.Name6);
                    hiscoreData.Scene7 = hiscoreData.Scene6;
                    HiConvert.ByteArrayCopy(hiscoreData.Time7, hiscoreData.Time6);
                    if (rank < 5)
                        goto case 4;
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, hiscoreData.Score7);
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, hiscoreData.Name7);
                    hiscoreData.Scene8 = hiscoreData.Scene7;
                    HiConvert.ByteArrayCopy(hiscoreData.Time8, hiscoreData.Time7);
                    if (rank < 6)
                        goto case 5;
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, hiscoreData.Score8);
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, hiscoreData.Name8);
                    hiscoreData.Scene9 = hiscoreData.Scene8;
                    HiConvert.ByteArrayCopy(hiscoreData.Time9, hiscoreData.Time8);
                    if (rank < 7)
                        goto case 6;
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, hiscoreData.Score9);
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, hiscoreData.Name9);
                    hiscoreData.Scene10 = hiscoreData.Scene9;
                    HiConvert.ByteArrayCopy(hiscoreData.Time10, hiscoreData.Time9);
                    if (rank < 8)
                        goto case 7;
                    break;
                default:
                    break;
            }
            #endregion

            #region REPLACE_NEW
            switch (rank)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.IntToByteArrayHex(score, hiscoreData.Score1.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name1, StringToByteArray(name));
                    hiscoreData.Scene1 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time1, HiConvert.IntToByteArrayHex(time, hiscoreData.Time1.Length));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.IntToByteArrayHex(score, hiscoreData.Score2.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    hiscoreData.Scene2 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time2, HiConvert.IntToByteArrayHex(time, hiscoreData.Time2.Length));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.IntToByteArrayHex(score, hiscoreData.Score3.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    hiscoreData.Scene3 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time3, HiConvert.IntToByteArrayHex(time, hiscoreData.Time3.Length));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.IntToByteArrayHex(score, hiscoreData.Score4.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    hiscoreData.Scene4 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time4, HiConvert.IntToByteArrayHex(time, hiscoreData.Time4.Length));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.IntToByteArrayHex(score, hiscoreData.Score5.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    hiscoreData.Scene5 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time5, HiConvert.IntToByteArrayHex(time, hiscoreData.Time5.Length));
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, HiConvert.IntToByteArrayHex(score, hiscoreData.Score6.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, StringToByteArray(name));
                    hiscoreData.Scene6 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time6, HiConvert.IntToByteArrayHex(time, hiscoreData.Time6.Length));
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, HiConvert.IntToByteArrayHex(score, hiscoreData.Score7.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, StringToByteArray(name));
                    hiscoreData.Scene7 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time7, HiConvert.IntToByteArrayHex(time, hiscoreData.Time7.Length));
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, HiConvert.IntToByteArrayHex(score, hiscoreData.Score8.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, StringToByteArray(name));
                    hiscoreData.Scene8 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time8, HiConvert.IntToByteArrayHex(time, hiscoreData.Time8.Length));
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, HiConvert.IntToByteArrayHex(score, hiscoreData.Score9.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, StringToByteArray(name));
                    hiscoreData.Scene9 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time9, HiConvert.IntToByteArrayHex(time, hiscoreData.Time9.Length));
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, HiConvert.IntToByteArrayHex(score, hiscoreData.Score10.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, StringToByteArray(name));
                    hiscoreData.Scene10 = (byte)scene;
                    HiConvert.ByteArrayCopy(hiscoreData.Time10, HiConvert.IntToByteArrayHex(time, hiscoreData.Time10.Length));
                    break;
                default:
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
            HiConvert.ByteArrayCopy(hiscoreData.Score6, HiConvert.IntToByteArrayHex(0, hiscoreData.Score6.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score7, HiConvert.IntToByteArrayHex(0, hiscoreData.Score7.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score8, HiConvert.IntToByteArrayHex(0, hiscoreData.Score8.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score9, HiConvert.IntToByteArrayHex(0, hiscoreData.Score9.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score10, HiConvert.IntToByteArrayHex(0, hiscoreData.Score10.Length));

            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        //TODO: DO time better...
        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 1, HiConvert.ByteArrayHexToInt(hiscoreData.Score1), ByteArrayToString(hiscoreData.Name1), hiscoreData.Scene1, HiConvert.ByteArrayHexToInt(hiscoreData.Time1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 2, HiConvert.ByteArrayHexToInt(hiscoreData.Score2), ByteArrayToString(hiscoreData.Name2), hiscoreData.Scene2, HiConvert.ByteArrayHexToInt(hiscoreData.Time2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 3, HiConvert.ByteArrayHexToInt(hiscoreData.Score3), ByteArrayToString(hiscoreData.Name3), hiscoreData.Scene3, HiConvert.ByteArrayHexToInt(hiscoreData.Time3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 4, HiConvert.ByteArrayHexToInt(hiscoreData.Score4), ByteArrayToString(hiscoreData.Name4), hiscoreData.Scene4, HiConvert.ByteArrayHexToInt(hiscoreData.Time4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 5, HiConvert.ByteArrayHexToInt(hiscoreData.Score5), ByteArrayToString(hiscoreData.Name5), hiscoreData.Scene5, HiConvert.ByteArrayHexToInt(hiscoreData.Time5)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 6, HiConvert.ByteArrayHexToInt(hiscoreData.Score6), ByteArrayToString(hiscoreData.Name6), hiscoreData.Scene6, HiConvert.ByteArrayHexToInt(hiscoreData.Time6)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 7, HiConvert.ByteArrayHexToInt(hiscoreData.Score7), ByteArrayToString(hiscoreData.Name7), hiscoreData.Scene7, HiConvert.ByteArrayHexToInt(hiscoreData.Time7)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 8, HiConvert.ByteArrayHexToInt(hiscoreData.Score8), ByteArrayToString(hiscoreData.Name8), hiscoreData.Scene8, HiConvert.ByteArrayHexToInt(hiscoreData.Time8)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 9, HiConvert.ByteArrayHexToInt(hiscoreData.Score9), ByteArrayToString(hiscoreData.Name9), hiscoreData.Scene9, HiConvert.ByteArrayHexToInt(hiscoreData.Time9)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}|{3}|{4}", 10, HiConvert.ByteArrayHexToInt(hiscoreData.Score10), ByteArrayToString(hiscoreData.Name10), hiscoreData.Scene10, HiConvert.ByteArrayHexToInt(hiscoreData.Time10)) + Environment.NewLine;

            return retString;
        }
    }
}

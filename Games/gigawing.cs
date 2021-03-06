using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class gigawing : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] HiScore;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Score20;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Name20;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Type20;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Stage20;
        }

        public gigawing()
        {
            m_numEntries = 20;
            m_format = "RANK|SCORE|NAME|TYPE|STAGE";
            m_gamesSupported = "gigawing,gwingj,gwinga,gwingb,gwingjd";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i = i + 2)
            {
                if (data[i] == 0x00)
                {
                    if (data[i+1] == 0xfc)
                        sb.Append('.');
                    else if (data[i+1] == 0xc4)
                        sb.Append(' ');
                    else if (data[i + 1] == 0x00)
                        sb.Append(' ');
                    else if (data[i+1] == 0xc8)
                        sb.Append('!');
                }
                else if (data[i] == 0x01)
                {
                    if (data[i+1] >= 0x48 && data[i+1] <= 0xac)
                        sb.Append(((char)((((int)data[i+1]) / 4) + 65 - 0x12)));
                    else if (data[i+1] == 0x04)
                        sb.Append('0');
                    else if (data[i+1] == 0x08)
                        sb.Append('1');
                    else if (data[i+1] == 0x0c)
                        sb.Append('2');
                    else if (data[i+1] == 0x10)
                        sb.Append('3');
                    else if (data[i+1] == 0x14)
                        sb.Append('4');
                    else if (data[i+1] == 0x18)
                        sb.Append('5');
                    else if (data[i+1] == 0x1c)
                        sb.Append('6');
                    else if (data[i+1] == 0x20)
                        sb.Append('7');
                    else if (data[i+1] == 0x24)
                        sb.Append('8');
                    else if (data[i+1] == 0x28)
                        sb.Append('9');
                    else if (data[i+1] == 0xc4)
                        sb.Append(' ');
                    else if (data[i+1] == 0x40)
                        sb.Append('?');
                }
                else if (data[i] == 0x06)
                {
                    //Unsure how to support these right now, so using lower case letters.
                    if (data[i+1] == 0x46)
                        sb.Append('a'); //St.
                    else if (data[i+1] == 0x42)
                        sb.Append('b'); //.Jr
                    else if (data[i+1] == 0x3e)
                        sb.Append('c'); //Dr.
                }
                else if (data[i] == 0x07)
                {
                    if (data[i+1] == 0xa6)
                        sb.Append('☺');
                    else if (data[i+1] == 0xaa)
                        sb.Append('e'); //Angry face
                    else if (data[i+1] == 0xb2)
                        sb.Append('d'); //Straight face.
                    else if (data[i+1] == 0xae)
                        sb.Append('☹');
                    else if (data[i+1] == 0xc2)
                        sb.Append('♠');
                    else if (data[i+1] == 0xc6)
                        sb.Append('★');
                    else if (data[i+1] == 0xbe)
                        sb.Append('♣');
                    else if (data[i+1] == 0xba)
                        sb.Append('♦');
                    else if (data[i+1] == 0xb6)
                        sb.Append('♥');
                }
                else if (data[i] == 0x0c)
                {
                    if (data[i+1] == 0xbc)
                        sb.Append('…');
                    else if (data[i+1] == 0xb8)
                        sb.Append('♫');
                    else if (data[i+1] == 0xb4)
                        sb.Append('♪');
                }
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length * 2];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = (byte)((((int)str[i]) - 65 + 0x12) * 4);
                }
                else if (str[i] == '0')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x04;
                }
                else if (str[i] == '1')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x08;
                }
                else if (str[i] == '2')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x0c;
                }
                else if (str[i] == '3')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x10;
                }
                else if (str[i] == '4')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x14;
                }
                else if (str[i] == '5')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x18;
                }
                else if (str[i] == '6')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x1c;
                }
                else if (str[i] == '7')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x20;
                }
                else if (str[i] == '8')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x24;
                }
                else if (str[i] == '9')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x28;
                }
                else if (str[i] == '…')
                {
                    data[(i * 2)] = 0x0c;
                    data[(i * 2) + 1] = 0xbc;
                }
                else if (str[i] == '.')
                {
                    data[(i * 2)] = 0x00;
                    data[(i * 2) + 1] = 0xfc;
                }
                else if (str[i] == '♫')
                {
                    data[(i * 2)] = 0x0c;
                    data[(i * 2) + 1] = 0xb8;
                }
                else if (str[i] == ' ')
                {
                    data[(i * 2)] = 0x00;
                    data[(i * 2) + 1] = 0xc4;
                }
                else if (str[i] == '♠')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xc2;
                }
                else if (str[i] == '★')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xc6;
                }
                else if (str[i] == '♪')
                {
                    data[(i * 2)] = 0x0c;
                    data[(i * 2) + 1] = 0xb4;
                }
                else if (str[i] == 'a')
                {
                    data[(i * 2)] = 0x06;
                    data[(i * 2) + 1] = 0x46;
                }
                else if (str[i] == 'b')
                {
                    data[(i * 2)] = 0x06;
                    data[(i * 2) + 1] = 0x42;
                }
                else if (str[i] == 'c')
                {
                    data[(i * 2)] = 0x06;
                    data[(i * 2) + 1] = 0x3e;
                }
                else if (str[i] == 'd')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xb2;
                }
                else if (str[i] == 'e')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xaa;
                }
                else if (str[i] == '☺')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xa6;
                }
                else if (str[i] == '?')
                {
                    data[(i * 2)] = 0x01;
                    data[(i * 2) + 1] = 0x40;
                }
                else if (str[i] == '!')
                {
                    data[(i * 2)] = 0x00;
                    data[(i * 2) + 1] = 0xc8;
                }
                else if (str[i] == '♣')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xbe;
                }
                else if (str[i] == '♦')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xba;
                }
                else if (str[i] == '♥')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xb6;
                }
                else if (str[i] == '☹')
                {
                    data[(i * 2)] = 0x07;
                    data[(i * 2) + 1] = 0xae;
                }
            }

            return data;
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            long score = System.Convert.ToInt64(args[1]);
            string name = args[2];
            int type = System.Convert.ToInt32(args[3]);
            int stage = System.Convert.ToInt32(args[4]);

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = 20;
            if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score1))
                rank = 0;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score2))
                rank = 1;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score3))
                rank = 2;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score4))
                rank = 3;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score5))
                rank = 4;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score6))
                rank = 5;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score7))
                rank = 6;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score8))
                rank = 7;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score9))
                rank = 8;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score10))
                rank = 9;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score11))
                rank = 10;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score12))
                rank = 11;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score13))
                rank = 12;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score14))
                rank = 13;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score15))
                rank = 14;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score16))
                rank = 15;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score17))
                rank = 16;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score18))
                rank = 17;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score19))
                rank = 18;
            else if (score > HiConvert.ByteArrayHexToLong(hiscoreData.Score20))
                rank = 19;
            #endregion

            #region ADJUST
            int adjust = 19;
            if (rank < 19)
                adjust = 18;
            switch (adjust)
            {
                case 0:
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, hiscoreData.Score1);
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, hiscoreData.Name1);
                    HiConvert.ByteArrayCopy(hiscoreData.Type2, hiscoreData.Type1);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage2, hiscoreData.Stage1);
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, hiscoreData.Score2);
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, hiscoreData.Name2);
                    HiConvert.ByteArrayCopy(hiscoreData.Type3, hiscoreData.Type2);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage3, hiscoreData.Stage2);
                    if (rank < 1)
                        goto case 0;
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, hiscoreData.Score3);
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, hiscoreData.Name3);
                    HiConvert.ByteArrayCopy(hiscoreData.Type4, hiscoreData.Type3);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage4, hiscoreData.Stage3);
                    if (rank < 2)
                        goto case 1;
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, hiscoreData.Score4);
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, hiscoreData.Name4);
                    HiConvert.ByteArrayCopy(hiscoreData.Type5, hiscoreData.Type4);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage5, hiscoreData.Stage4);
                    if (rank < 3)
                        goto case 2;
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, hiscoreData.Score5);
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, hiscoreData.Name5);
                    HiConvert.ByteArrayCopy(hiscoreData.Type6, hiscoreData.Type5);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage6, hiscoreData.Stage5);
                    if (rank < 4)
                        goto case 3;
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, hiscoreData.Score6);
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, hiscoreData.Name6);
                    HiConvert.ByteArrayCopy(hiscoreData.Type7, hiscoreData.Type6);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage7, hiscoreData.Stage6);
                    if (rank < 5)
                        goto case 4;
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, hiscoreData.Score7);
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, hiscoreData.Name7);
                    HiConvert.ByteArrayCopy(hiscoreData.Type8, hiscoreData.Type7);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage8, hiscoreData.Stage7);
                    if (rank < 6)
                        goto case 5;
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, hiscoreData.Score8);
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, hiscoreData.Name8);
                    HiConvert.ByteArrayCopy(hiscoreData.Type9, hiscoreData.Type8);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage9, hiscoreData.Stage8);
                    if (rank < 7)
                        goto case 6;
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, hiscoreData.Score9);
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, hiscoreData.Name9);
                    HiConvert.ByteArrayCopy(hiscoreData.Type10, hiscoreData.Type9);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage10, hiscoreData.Stage9);
                    if (rank < 8)
                        goto case 7;
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.Score11, hiscoreData.Score10);
                    HiConvert.ByteArrayCopy(hiscoreData.Name11, hiscoreData.Name10);
                    HiConvert.ByteArrayCopy(hiscoreData.Type11, hiscoreData.Type10);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage11, hiscoreData.Stage10);
                    if (rank < 9)
                        goto case 8;
                    break;
                case 10:
                    HiConvert.ByteArrayCopy(hiscoreData.Score12, hiscoreData.Score11);
                    HiConvert.ByteArrayCopy(hiscoreData.Name12, hiscoreData.Name11);
                    HiConvert.ByteArrayCopy(hiscoreData.Type12, hiscoreData.Type11);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage12, hiscoreData.Stage11);
                    if (rank < 10)
                        goto case 9;
                    break;
                case 11:
                    HiConvert.ByteArrayCopy(hiscoreData.Score13, hiscoreData.Score12);
                    HiConvert.ByteArrayCopy(hiscoreData.Name13, hiscoreData.Name12);
                    HiConvert.ByteArrayCopy(hiscoreData.Type13, hiscoreData.Type12);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage13, hiscoreData.Stage12);
                    if (rank < 11)
                        goto case 10;
                    break;
                case 12:
                    HiConvert.ByteArrayCopy(hiscoreData.Score14, hiscoreData.Score13);
                    HiConvert.ByteArrayCopy(hiscoreData.Name14, hiscoreData.Name13);
                    HiConvert.ByteArrayCopy(hiscoreData.Type14, hiscoreData.Type13);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage14, hiscoreData.Stage13);
                    if (rank < 12)
                        goto case 11;
                    break;
                case 13:
                    HiConvert.ByteArrayCopy(hiscoreData.Score15, hiscoreData.Score14);
                    HiConvert.ByteArrayCopy(hiscoreData.Name15, hiscoreData.Name14);
                    HiConvert.ByteArrayCopy(hiscoreData.Type15, hiscoreData.Type14);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage15, hiscoreData.Stage14);
                    if (rank < 13)
                        goto case 12;
                    break;
                case 14:
                    HiConvert.ByteArrayCopy(hiscoreData.Score16, hiscoreData.Score15);
                    HiConvert.ByteArrayCopy(hiscoreData.Name16, hiscoreData.Name15);
                    HiConvert.ByteArrayCopy(hiscoreData.Type16, hiscoreData.Type15);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage16, hiscoreData.Stage15);
                    if (rank < 14)
                        goto case 13;
                    break;
                case 15:
                    HiConvert.ByteArrayCopy(hiscoreData.Score17, hiscoreData.Score16);
                    HiConvert.ByteArrayCopy(hiscoreData.Name17, hiscoreData.Name16);
                    HiConvert.ByteArrayCopy(hiscoreData.Type17, hiscoreData.Type16);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage17, hiscoreData.Stage16);
                    if (rank < 15)
                        goto case 14;
                    break;
                case 16:
                    HiConvert.ByteArrayCopy(hiscoreData.Score18, hiscoreData.Score17);
                    HiConvert.ByteArrayCopy(hiscoreData.Name18, hiscoreData.Name17);
                    HiConvert.ByteArrayCopy(hiscoreData.Type18, hiscoreData.Type17);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage18, hiscoreData.Stage17);
                    if (rank < 16)
                        goto case 15;
                    break;
                case 17:
                    HiConvert.ByteArrayCopy(hiscoreData.Score19, hiscoreData.Score18);
                    HiConvert.ByteArrayCopy(hiscoreData.Name19, hiscoreData.Name18);
                    HiConvert.ByteArrayCopy(hiscoreData.Type19, hiscoreData.Type18);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage19, hiscoreData.Stage18);
                    if (rank < 17)
                        goto case 16;
                    break;
                case 18:
                    HiConvert.ByteArrayCopy(hiscoreData.Score20, hiscoreData.Score19);
                    HiConvert.ByteArrayCopy(hiscoreData.Name20, hiscoreData.Name19);
                    HiConvert.ByteArrayCopy(hiscoreData.Type20, hiscoreData.Type19);
                    HiConvert.ByteArrayCopy(hiscoreData.Stage20, hiscoreData.Stage19);
                    if (rank < 18)
                        goto case 17;
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
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.HiScore, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type1, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage1, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type2, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage2, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type3, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage3, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type4, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage4, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type5, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage5, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type6, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage6, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type7, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage7, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type8, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage8, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type9, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage9, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type10, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage10, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 10:
                    HiConvert.ByteArrayCopy(hiscoreData.Name11, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score11, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type11, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage11, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 11:
                    HiConvert.ByteArrayCopy(hiscoreData.Name12, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score12, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type12, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage12, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 12:
                    HiConvert.ByteArrayCopy(hiscoreData.Name13, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score13, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type13, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage13, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 13:
                    HiConvert.ByteArrayCopy(hiscoreData.Name14, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score14, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type14, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage14, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 14:
                    HiConvert.ByteArrayCopy(hiscoreData.Name15, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score15, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type15, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage15, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 15:
                    HiConvert.ByteArrayCopy(hiscoreData.Name16, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score16, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type16, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage16, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 16:
                    HiConvert.ByteArrayCopy(hiscoreData.Name17, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score17, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type17, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage17, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 17:
                    HiConvert.ByteArrayCopy(hiscoreData.Name18, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score18, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type18, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage18, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 18:
                    HiConvert.ByteArrayCopy(hiscoreData.Name19, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score19, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type19, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage19, HiConvert.HexStringToByteArray(stage.ToString("D4")));
                    break;
                case 19:
                    HiConvert.ByteArrayCopy(hiscoreData.Name20, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score20, HiConvert.HexStringToByteArray(score.ToString("D16")));
                    HiConvert.ByteArrayCopy(hiscoreData.Type20, HiConvert.HexStringToByteArray(type.ToString("D4")));
                    HiConvert.ByteArrayCopy(hiscoreData.Stage20, HiConvert.HexStringToByteArray(stage.ToString("D4")));
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
            HiConvert.ByteArrayCopy(hiscoreData.Score11, HiConvert.IntToByteArrayHex(0, hiscoreData.Score11.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score12, HiConvert.IntToByteArrayHex(0, hiscoreData.Score12.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score13, HiConvert.IntToByteArrayHex(0, hiscoreData.Score13.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score14, HiConvert.IntToByteArrayHex(0, hiscoreData.Score14.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score15, HiConvert.IntToByteArrayHex(0, hiscoreData.Score15.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score16, HiConvert.IntToByteArrayHex(0, hiscoreData.Score16.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score17, HiConvert.IntToByteArrayHex(0, hiscoreData.Score17.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score18, HiConvert.IntToByteArrayHex(0, hiscoreData.Score18.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score19, HiConvert.IntToByteArrayHex(0, hiscoreData.Score19.Length));
            HiConvert.ByteArrayCopy(hiscoreData.Score20, HiConvert.IntToByteArrayHex(0, hiscoreData.Score20.Length));
            
            byte[] byteArray = HiConvert.RawSerialize(hiscoreData);

            HiConvert.ByteArrayCopy(m_data, byteArray);

            SaveData();
        }

        public override string HiToString()
        {
            string retString = m_format + Environment.NewLine;

            HiscoreData hiscoreData = new HiscoreData();
            hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}", 
                1,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score1), 
                ByteArrayToString(hiscoreData.Name1), 
                HiConvert.ByteArrayHexToInt(hiscoreData.Type1), 
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage1)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                2,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score2),
                ByteArrayToString(hiscoreData.Name2),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type2),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage2)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                3,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score3),
                ByteArrayToString(hiscoreData.Name3),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type3),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage3)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                4,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score4),
                ByteArrayToString(hiscoreData.Name4),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type4),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage4)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                5,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score5),
                ByteArrayToString(hiscoreData.Name5),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type5),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage5)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                6,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score6),
                ByteArrayToString(hiscoreData.Name6),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type6),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage6)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                7,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score7),
                ByteArrayToString(hiscoreData.Name7),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type7),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage7)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                8,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score8),
                ByteArrayToString(hiscoreData.Name8),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type8),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage8)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                9,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score9),
                ByteArrayToString(hiscoreData.Name9),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type9),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage9)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                10,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score10),
                ByteArrayToString(hiscoreData.Name10),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type10),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage10)) + Environment.NewLine;
            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                11,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score11),
                ByteArrayToString(hiscoreData.Name11),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type11),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage11)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                12,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score12),
                ByteArrayToString(hiscoreData.Name12),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type12),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage12)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                13,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score13),
                ByteArrayToString(hiscoreData.Name13),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type13),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage13)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                14,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score14),
                ByteArrayToString(hiscoreData.Name14),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type14),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage14)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                15,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score15),
                ByteArrayToString(hiscoreData.Name15),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type15),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage15)) + Environment.NewLine;
            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                16,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score16),
                ByteArrayToString(hiscoreData.Name16),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type16),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage16)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                17,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score17),
                ByteArrayToString(hiscoreData.Name17),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type17),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage17)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                18,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score18),
                ByteArrayToString(hiscoreData.Name18),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type18),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage18)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                19,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score19),
                ByteArrayToString(hiscoreData.Name19),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type19),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage19)) + Environment.NewLine;

            retString += String.Format(
                "{0}|{1}|{2}|{3}|{4}",
                20,
                HiConvert.ByteArrayHexToLong(hiscoreData.Score20),
                ByteArrayToString(hiscoreData.Name20),
                HiConvert.ByteArrayHexToInt(hiscoreData.Type20),
                HiConvert.ByteArrayHexToInt(hiscoreData.Stage20)) + Environment.NewLine;

            return retString;
        }
    }
}


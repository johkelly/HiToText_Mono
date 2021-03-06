using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using HiToText;
using HiToText.Utils;

namespace HiGames
{
    class wboy : Hiscore
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
        public struct HiscoreData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name1;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name2;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name3;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name4;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional4;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name5;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional5;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name6;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional6;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name7;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional7;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name8;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional8;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name9;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional9;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name10;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional10;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name11;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional11;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name12;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional12;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name13;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional13;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name14;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional14;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name15;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional15;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name16;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional16;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name17;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional17;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name18;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional18;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name19;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional19;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank20;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score20;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name20;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional20;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Rank21;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
            public byte[] Score21;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] Name21;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
            public byte[] NameAdditional21;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
            public byte[] HiScore;
        }

        public wboy()
        {
            m_numEntries = 20;
            m_format = "RANK|SCORE|NAME";
            m_gamesSupported = "wboy,wboy2,wboy3,wboy4,wboy4u,wboyu,wbdeluxe,wboyo,wboy2u";
            m_extensionsRequired = ".hi";
        }

        public string ByteArrayToString(byte[] data)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 0x5c)
                    sb.Append('⍥');
                else if (data[i] == 0x5e)
                    sb.Append('❥');
                else if (data[i] == 0x7d)
                    sb.Append('♀');
                else if (data[i] == 0x7e)
                    sb.Append('♂');
                else if (data[i] == 0x7f)
                    sb.Append('♥');
                else
                    sb.Append((char)(int)data[i]);
            }

            return sb.ToString();
        }

        public byte[] StringToByteArray(string str)
        {
            byte[] data = new byte[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '⍥')
                    data[i] = 0x5c;
                else if (str[i] == '❥')
                    data[i] = 0x5e;
                else if (str[i] == '♀')
                    data[i] = 0x7d;
                else if (str[i] == '♂')
                    data[i] = 0x7e;
                else if (str[i] == '♥')
                    data[i] = 0x5b;
                else
                    data[i] = (byte)((int)str[i]);
            }

            return data;
        }

        public int GetScore(byte[] score)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < score.Length; i++)
            {
                if (score[i] != 0x20)
                    sb.Append((char)(int)score[i]);
            }

            return Convert.ToInt32(sb.ToString());
        }

        public byte[] GetScore(int score, int numDigitsInScore)
        {
            StringBuilder sb = new StringBuilder();
            String strScore = score.ToString();
            strScore = strScore.PadLeft(numDigitsInScore, 'F');

            for (int i = 0; i < numDigitsInScore; i++)
            {
                if (strScore[i].Equals('F'))
                    sb.Append("20");
                else
                    sb.Append("3" + strScore[i].ToString());
            }

            return HiConvert.HexStringToByteArray(sb.ToString());
        }

        public byte[] GetHiScore(int score)
        {
            int numDigitsInScore = 7;

            StringBuilder sb = new StringBuilder();
            String strScore = score.ToString();
            strScore = strScore.PadLeft(numDigitsInScore, 'F');

            for (int i = 0; i < numDigitsInScore; i++)
            {
                if (strScore[i].Equals('F'))
                    sb.Append("01");
                else
                    sb.Append("1" + strScore[i].ToString());

                if (i != numDigitsInScore - 1)
                    sb.Append("08");
            }

            return HiConvert.HexStringToByteArray(sb.ToString());
        }

        public override void SetHiScore(string[] args)
        {
            int rankGiven = Convert.ToInt32(args[0]);
            int score = System.Convert.ToInt32(args[1]) / 10;
            string name = args[2];

            HiscoreData hiscoreData = (HiscoreData)HiConvert.RawDeserialize(m_data, 0, typeof(HiscoreData));

            #region DETERMINE_RANK
            int rank = NumEntries;
            if (score > GetScore(hiscoreData.Score1))
                rank = 0;
            else if (score > GetScore(hiscoreData.Score2))
                rank = 1;
            else if (score > GetScore(hiscoreData.Score3))
                rank = 2;
            else if (score > GetScore(hiscoreData.Score4))
                rank = 3;
            else if (score > GetScore(hiscoreData.Score5))
                rank = 4;
            else if (score > GetScore(hiscoreData.Score6))
                rank = 5;
            else if (score > GetScore(hiscoreData.Score7))
                rank = 6;
            else if (score > GetScore(hiscoreData.Score8))
                rank = 7;
            else if (score > GetScore(hiscoreData.Score9))
                rank = 8;
            else if (score > GetScore(hiscoreData.Score10))
                rank = 9;
            else if (score > GetScore(hiscoreData.Score11))
                rank = 10;
            else if (score > GetScore(hiscoreData.Score12))
                rank = 11;
            else if (score > GetScore(hiscoreData.Score13))
                rank = 12;
            else if (score > GetScore(hiscoreData.Score14))
                rank = 13;
            else if (score > GetScore(hiscoreData.Score15))
                rank = 14;
            else if (score > GetScore(hiscoreData.Score16))
                rank = 15;
            else if (score > GetScore(hiscoreData.Score17))
                rank = 16;
            else if (score > GetScore(hiscoreData.Score18))
                rank = 17;
            else if (score > GetScore(hiscoreData.Score19))
                rank = 18;
            else if (score > GetScore(hiscoreData.Score20))
                rank = 19;
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
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, hiscoreData.Score5);
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, hiscoreData.Name5);
                    if (rank < 4)
                        goto case 3;
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, hiscoreData.Score6);
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, hiscoreData.Name6);
                    if (rank < 5)
                        goto case 4;
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, hiscoreData.Score7);
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, hiscoreData.Name7);
                    if (rank < 6)
                        goto case 5;
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, hiscoreData.Score8);
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, hiscoreData.Name8);
                    if (rank < 7)
                        goto case 6;
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, hiscoreData.Score9);
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, hiscoreData.Name9);
                    if (rank < 8)
                        goto case 7;
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.Score11, hiscoreData.Score10);
                    HiConvert.ByteArrayCopy(hiscoreData.Name11, hiscoreData.Name10);
                    if (rank < 9)
                        goto case 8;
                    break;
                case 10:
                    HiConvert.ByteArrayCopy(hiscoreData.Score12, hiscoreData.Score11);
                    HiConvert.ByteArrayCopy(hiscoreData.Name12, hiscoreData.Name11);
                    if (rank < 10)
                        goto case 9;
                    break;
                case 11:
                    HiConvert.ByteArrayCopy(hiscoreData.Score13, hiscoreData.Score12);
                    HiConvert.ByteArrayCopy(hiscoreData.Name13, hiscoreData.Name12);
                    if (rank < 11)
                        goto case 10;
                    break;
                case 12:
                    HiConvert.ByteArrayCopy(hiscoreData.Score14, hiscoreData.Score13);
                    HiConvert.ByteArrayCopy(hiscoreData.Name14, hiscoreData.Name13);
                    if (rank < 12)
                        goto case 11;
                    break;
                case 13:
                    HiConvert.ByteArrayCopy(hiscoreData.Score15, hiscoreData.Score14);
                    HiConvert.ByteArrayCopy(hiscoreData.Name15, hiscoreData.Name14);
                    if (rank < 13)
                        goto case 12;
                    break;
                case 14:
                    HiConvert.ByteArrayCopy(hiscoreData.Score16, hiscoreData.Score15);
                    HiConvert.ByteArrayCopy(hiscoreData.Name16, hiscoreData.Name15);
                    if (rank < 14)
                        goto case 13;
                    break;
                case 15:
                    HiConvert.ByteArrayCopy(hiscoreData.Score17, hiscoreData.Score16);
                    HiConvert.ByteArrayCopy(hiscoreData.Name17, hiscoreData.Name16);
                    if (rank < 15)
                        goto case 14;
                    break;
                case 16:
                    HiConvert.ByteArrayCopy(hiscoreData.Score18, hiscoreData.Score17);
                    HiConvert.ByteArrayCopy(hiscoreData.Name18, hiscoreData.Name17);
                    if (rank < 16)
                        goto case 15;
                    break;
                case 17:
                    HiConvert.ByteArrayCopy(hiscoreData.Score19, hiscoreData.Score18);
                    HiConvert.ByteArrayCopy(hiscoreData.Name19, hiscoreData.Name18);
                    if (rank < 17)
                        goto case 16;
                    break;
                case 18:
                    HiConvert.ByteArrayCopy(hiscoreData.Score20, hiscoreData.Score19);
                    HiConvert.ByteArrayCopy(hiscoreData.Name20, hiscoreData.Name19);
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
                    HiConvert.ByteArrayCopy(hiscoreData.Score1, GetScore(score, hiscoreData.Score1.Length));
                    HiConvert.ByteArrayCopy(hiscoreData.HiScore, GetHiScore(score));
                    break;
                case 1:
                    HiConvert.ByteArrayCopy(hiscoreData.Name2, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score2, GetScore(score, hiscoreData.Score2.Length));
                    break;
                case 2:
                    HiConvert.ByteArrayCopy(hiscoreData.Name3, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score3, GetScore(score, hiscoreData.Score3.Length));
                    break;
                case 3:
                    HiConvert.ByteArrayCopy(hiscoreData.Name4, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score4, GetScore(score, hiscoreData.Score4.Length));
                    break;
                case 4:
                    HiConvert.ByteArrayCopy(hiscoreData.Name5, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score5, GetScore(score, hiscoreData.Score5.Length));
                    break;
                case 5:
                    HiConvert.ByteArrayCopy(hiscoreData.Name6, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score6, GetScore(score, hiscoreData.Score6.Length));
                    break;
                case 6:
                    HiConvert.ByteArrayCopy(hiscoreData.Name7, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score7, GetScore(score, hiscoreData.Score7.Length));
                    break;
                case 7:
                    HiConvert.ByteArrayCopy(hiscoreData.Name8, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score8, GetScore(score, hiscoreData.Score8.Length));
                    break;
                case 8:
                    HiConvert.ByteArrayCopy(hiscoreData.Name9, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score9, GetScore(score, hiscoreData.Score9.Length));
                    break;
                case 9:
                    HiConvert.ByteArrayCopy(hiscoreData.Name10, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score10, GetScore(score, hiscoreData.Score10.Length));
                    break;
                case 10:
                    HiConvert.ByteArrayCopy(hiscoreData.Name11, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score11, GetScore(score, hiscoreData.Score11.Length));
                    break;
                case 11:
                    HiConvert.ByteArrayCopy(hiscoreData.Name12, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score12, GetScore(score, hiscoreData.Score12.Length));
                    break;
                case 12:
                    HiConvert.ByteArrayCopy(hiscoreData.Name13, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score13, GetScore(score, hiscoreData.Score13.Length));
                    break;
                case 13:
                    HiConvert.ByteArrayCopy(hiscoreData.Name14, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score14, GetScore(score, hiscoreData.Score14.Length));
                    break;
                case 14:
                    HiConvert.ByteArrayCopy(hiscoreData.Name15, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score15, GetScore(score, hiscoreData.Score15.Length));
                    break;
                case 15:
                    HiConvert.ByteArrayCopy(hiscoreData.Name16, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score16, GetScore(score, hiscoreData.Score16.Length));
                    break;
                case 16:
                    HiConvert.ByteArrayCopy(hiscoreData.Name17, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score17, GetScore(score, hiscoreData.Score17.Length));
                    break;
                case 17:
                    HiConvert.ByteArrayCopy(hiscoreData.Name18, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score18, GetScore(score, hiscoreData.Score18.Length));
                    break;
                case 18:
                    HiConvert.ByteArrayCopy(hiscoreData.Name19, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score19, GetScore(score, hiscoreData.Score19.Length));
                    break;
                case 19:
                    HiConvert.ByteArrayCopy(hiscoreData.Name20, StringToByteArray(name));
                    HiConvert.ByteArrayCopy(hiscoreData.Score20, GetScore(score, hiscoreData.Score20.Length));
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

            retString += String.Format("{0}|{1}|{2}", 1, GetScore(hiscoreData.Score1) * 10, ByteArrayToString(hiscoreData.Name1)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 2, GetScore(hiscoreData.Score2) * 10, ByteArrayToString(hiscoreData.Name2)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 3, GetScore(hiscoreData.Score3) * 10, ByteArrayToString(hiscoreData.Name3)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 4, GetScore(hiscoreData.Score4) * 10, ByteArrayToString(hiscoreData.Name4)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 5, GetScore(hiscoreData.Score5) * 10, ByteArrayToString(hiscoreData.Name5)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 6, GetScore(hiscoreData.Score6) * 10, ByteArrayToString(hiscoreData.Name6)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 7, GetScore(hiscoreData.Score7) * 10, ByteArrayToString(hiscoreData.Name7)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 8, GetScore(hiscoreData.Score8) * 10, ByteArrayToString(hiscoreData.Name8)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 9, GetScore(hiscoreData.Score9) * 10, ByteArrayToString(hiscoreData.Name9)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 10, GetScore(hiscoreData.Score10) * 10, ByteArrayToString(hiscoreData.Name10)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 11, GetScore(hiscoreData.Score11) * 10, ByteArrayToString(hiscoreData.Name11)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 12, GetScore(hiscoreData.Score12) * 10, ByteArrayToString(hiscoreData.Name12)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 13, GetScore(hiscoreData.Score13) * 10, ByteArrayToString(hiscoreData.Name13)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 14, GetScore(hiscoreData.Score14) * 10, ByteArrayToString(hiscoreData.Name14)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 15, GetScore(hiscoreData.Score15) * 10, ByteArrayToString(hiscoreData.Name15)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 16, GetScore(hiscoreData.Score16) * 10, ByteArrayToString(hiscoreData.Name16)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 17, GetScore(hiscoreData.Score17) * 10, ByteArrayToString(hiscoreData.Name17)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 18, GetScore(hiscoreData.Score18) * 10, ByteArrayToString(hiscoreData.Name18)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 19, GetScore(hiscoreData.Score19) * 10, ByteArrayToString(hiscoreData.Name19)) + Environment.NewLine;
            retString += String.Format("{0}|{1}|{2}", 20, GetScore(hiscoreData.Score20) * 10, ByteArrayToString(hiscoreData.Name20)) + Environment.NewLine;

            return retString;
        }
    }
}
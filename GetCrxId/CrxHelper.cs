using System;
using System.Security.Cryptography;

namespace GetCrxId
{
    public static class CrxHelper
    {
        /// <summary>
        /// Base64解码
        /// </summary>
        /// <param name="pubKey">公钥</param>
        /// <returns>解码数据</returns>
        public static byte[] DecodeBase64(string pubKey)
        {

            byte[] bytes = Convert.FromBase64String(pubKey);

            return bytes;
        }

        /// <summary>
        /// Ord
        /// </summary>
        /// <param name="chr">将char转换为int，即字符转ASCII编码</param>
        /// <returns></returns>
        private static int Ord(char chr)
        {
            int result = (int)chr;
            return result;


        }

        /// <summary>
        /// Chr
        /// </summary>
        /// <param name="ascii">将int转换为char，即ASCII编码转字符</param>
        /// <returns></returns>
        private static char Chr(int ascii)
        {
            char result = (char)ascii;
            return result;
        }


        public static string GetSHA256(byte[] input)
        {

            SHA256 sha256 = new SHA256Managed();
            sha256.ComputeHash(input);
            byte[] hashedBytes = sha256.Hash;
            sha256.Clear();
            string output = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            return output;
        }


        /// <summary>
        /// Base16(128bit)编码
        /// </summary>
        /// <param name="str32">SHA256编码后的字符串的前32位数</param>
        /// <returns>处理后的字符串</returns>
        public static string EncodeBase16(string str32)
        {
            string newStr = string.Empty;
            foreach (char c in str32)
            {
                int code = Convert.ToInt16(c.ToString(), 16);
                newStr += Chr(97 + code);
            }
            return newStr;
        }
    }
}

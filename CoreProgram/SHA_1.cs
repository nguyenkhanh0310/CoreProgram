using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Numerics;

namespace CoreProgram
{
    public class SHA_1
    {
        //Hàm băm SHA1
        public static string SHA1(string text)
        {
            SHA1Managed sha1 = new SHA1Managed();
            byte[] hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x2"));
            }
            return hashSb.ToString();
        }

        //chuyển từ hệ hex sang hệ 10
        public static BigInteger HexToDecimal(string hexNumber)
        {
            BigInteger result = 0;
            foreach (char c in hexNumber)
            {
                if (char.IsDigit(c))
                {
                    result = result * 16 + (c - '0');
                }
                else
                {
                    int value = char.ToUpper(c) - 'A' + 10;
                    result = result * 16 + value;
                }
            }
            return result;
        }

        //Hàm băm SHA512
        public static string SHA512(string text)
        {
            SHA512Managed sha512 = new SHA512Managed();
            StringBuilder hashSb = new StringBuilder();
            byte[] hash = sha512.ComputeHash(Encoding.UTF8.GetBytes(text));
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("x2"));
            }
            return hashSb.ToString();
        }
        public static byte[] GetHash(string inputString)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        //Hàm băm SHA256
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString("X2"));

            return sb.ToString();
        }
    }
}

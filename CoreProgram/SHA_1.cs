using System;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace CoreProgram
{
    public class SHA_1
    {
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

    }

}

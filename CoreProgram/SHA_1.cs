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


    }

}

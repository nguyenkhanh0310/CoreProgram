using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CoreProgram
{
    public class utilities
    {
        public static BigInteger mod(this BigInteger dividend, BigInteger divisor)
        {
            BigInteger result = dividend % divisor;
            if (result < 0)
            {
                result += divisor;
            }
            return result;
        }

        public static BigInteger getRandomNumber(BigInteger min, BigInteger max)
        {
            Random random = new Random();
            BigInteger randomBigInteger = BigInteger.ProbablePrime()
        }
        public static Boolean isPrime(BigInteger n, int k)
        {
            if(n.CompareTo(BigInteger.One) <= 0 || mod(n, new BigInteger(2)).Equals(BigInteger.Zero))
            {
                return false;
            }

            // Tách n = d*2^s+1
            BigInteger d = n - 1;
            int s = 0;
            while (mod(d, new BigInteger(2)).Equals(BigInteger.Zero){
                s++;
                d = d / 2;
            }

            //Kiểm tra thuật toán với k lần lặp
            for(int i = 0; i < k; i++)
            {

            }
        }
        public static BigInteger generatePrimeNumber()
        {
            Random random = new Random();

            int value = random.Next(1000000000) + 1000000000;
            BigInteger q = new BigInteger(value);

            while()
        }
    }
}

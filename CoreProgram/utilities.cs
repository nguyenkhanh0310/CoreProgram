using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CoreProgram
{
    public static class utilities
    {
        // Hàm tính nghịch đảo trong modulo
        public static BigInteger NghichDao(BigInteger a, BigInteger n)
        {
            BigInteger r0, r1, r2, q, t0, t1;

            r0 = n;
            r1 = a;
            t0 = BigInteger.Zero;
            t1 = BigInteger.One;

            while (true)
            {
                r2 = r0 % r1;
                q = r0 / r1;
                if (r2.Equals(BigInteger.Zero))
                    break;

                BigInteger temp = t1;
                t1 = (t0 - q * t1) % n;
                if (t1.CompareTo(BigInteger.Zero) == -1)
                    t1 += n;
                r0 = r1;
                r1 = r2;
                t0 = temp;
            }

            if (r1.CompareTo(BigInteger.One) == 0)
                return t1;
            return BigInteger.MinusOne;
        }

        public static BigInteger mod(this BigInteger dividend, BigInteger divisor)
        {
            BigInteger result = dividend % divisor;
            if (result < 0)
            {
                result += divisor;
            }
            return result;
        }

        //Lay so ngau nhien trong khoang
        public static BigInteger GetRandomNumber(BigInteger min, BigInteger max)
        {
            Random random = new Random();
            BigInteger randomBigInteger;

            do
            {
                byte[] bytes = new byte[max.GetByteCount()];
                random.NextBytes(bytes);
                randomBigInteger = new BigInteger(bytes);
            } while (randomBigInteger<min || randomBigInteger > max );

            randomBigInteger = (randomBigInteger -min) % (max - min + 1) + min;
            return randomBigInteger;
        }
        //Kiểm tra tính nguyên tố bằng Miller Rabin với k lần thử
        public static bool IsPrime(BigInteger n, int k)
        {
            if (n <= 1) return false; // Handle non-positive numbers
            if (n <= 3) return true; // Handle small primes efficiently
            if (n % 2 == 0) return false;

            // Tách n = d*2^s+1
            int s = 0;
            BigInteger d = n - 1;
            while (d % 2 == 0)
            {
                s++;
                d /= 2;
            }
            //Kiểm tra thuật toán với k lần lặp
            for (int i = 0; i < k; i++)
            {
                BigInteger a = GetRandomNumber(2,n-2);
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1) continue;

                bool isPrime = false;
                for (int r =0; r < s-1; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x==1)
                        return false;
                    if (x == n - 1)
                    {
                        //isPrime = true;
                        break;
                    }
                        
                }
                if (!(x == n - 1)) return false;
            }

            return true;
        }

        //public static BigInteger GeneratePrimeNumber(int bit)
        //{
        //    Random random = new Random();
        //    BigInteger res;

        //    do
        //    {
        //        byte[] bytes = new byte[bit / 8];
        //        random.NextBytes(bytes);
        //        res = new BigInteger(bytes);

        //    } while (!IsPrime(res, 20));

        //    return res;
        //}

        public static BigInteger GeneratePrimeNumber()
        {
            Random random = new Random();
            BigInteger q;

            do
            {
                int value = random.Next(1000000000) + 1000000000;
                q = new BigInteger(value);
            } while (!IsPrime(q, 20));

            return q;
        }

        //Tinh p = q.z+1
        //public static biginteger generateprimenumberismultiple(biginteger q, int bit)
        //{
        //    using (randomnumbergenerator rng = randomnumbergenerator.create())
        //    {
        //         biginteger p;

        //         do
        //            {
        //                byte[] bytes = new byte[bit / 8];
        //                rng.getbytes(bytes);
        //                biginteger z = new biginteger(bytes);
        //                p = z * q + biginteger.one;
        //            } while (!isprime(p, 20));

        //            return p;
        //    }

        //}

        public static BigInteger GeneratePrimeNumberIsMultiple(BigInteger q)
        {
            Random rand = new Random();
            int value = rand.Next(1000000000) + 1000000000;
            BigInteger z = new BigInteger(value);
            BigInteger p = z * q + BigInteger.One;

            while (!IsPrime(p, 20))
            {
                value = rand.Next(1000000000) + 1000000000;
                z = new BigInteger(value);
                p = z * q + BigInteger.One;
            }

            return p;
        }
    }
}

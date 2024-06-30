using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace demoWF
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
        //Hàm tính a^b mod n
        public static BigInteger ModPow(BigInteger a, BigInteger b, BigInteger n)
        {
            if (b == 0) return 1; // a^0 = 1
            if (b == 1) return a % n; // a^1 = a mod n

            BigInteger result = 1;
            while (b > 0)
            {
                if (b % 2 == 1) result = (result * a) % n; // Multiply if odd power
                a = (a * a) % n; // Square the base
                b >>= 1; // Divide the exponent by 2
            }
            return result;
        }



        //Lay so ngau nhien trong khoang min den max
        public static BigInteger GetRandomNumber(BigInteger min, BigInteger max)
        {
            Random random = new Random();
            BigInteger randomBigInteger;

            do
            {
                byte[] bytes = new byte[max.GetByteCount()];
                random.NextBytes(bytes);
                randomBigInteger = new BigInteger(bytes);
            } while (randomBigInteger < min || randomBigInteger > max);

            //randomBigInteger = (randomBigInteger - min) % (max - min + 1) + min;
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
                BigInteger a = GetRandomNumber(2, n - 2);
                BigInteger x = BigInteger.ModPow(a, d, n); //ModPow hàm lũy thừa
                if (x == 1 || x == n - 1) continue;

                for (int r = 0; r < s - 1; r++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false;
                    if (x == n - 1)
                    {
                        break;
                    }

                }
                if (!(x == n - 1)) return false;
            }

            return true;
        }

        //Số nguyên tố lớn
        public static BigInteger GeneratePrimeNumber(int bit)
        {
            Random random = new Random();
            BigInteger res;

            do
            {
                byte[] bytes = new byte[bit / 8];
                random.NextBytes(bytes);
                res = new BigInteger(bytes);

            } while (!IsPrime(res, 20));

            return res;
        }

        //Số nguyên tố nhỏ
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

        //Tinh p = q.z+1, lấy số nguyên tố q là ước của p
        public static BigInteger GeneratePrimeNumberIsMultiple(BigInteger q, int bit)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                BigInteger p;

                do
                {
                    byte[] bytes = new byte[bit / 8];
                    rng.GetBytes(bytes);
                    BigInteger z = new BigInteger(bytes);
                    p = z * q + BigInteger.One;
                } while (!IsPrime(p, 20));

                return p;
            }

        }

        //Lấy số nguyên tố q là ước của p với q là int
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


namespace CoreProgram
{
    public class DSA_algorithm
    {
        private BigInteger p;
        private BigInteger q;
        private BigInteger g;
        private BigInteger h;
        private BigInteger x;
        private BigInteger y;

        public DSA_algorithm()
        {
        }

        public DSA_algorithm(BigInteger q)
        {
            this.q = q;
        }

        public BigInteger P
        {
            get { return p; }
            set { p = value; }
        }

        public BigInteger Q
        {
            get { return q; }
            set { q = value; }
        }

        public BigInteger G
        {
            get { return g; }
            set { g = value; }
        }

        public BigInteger H
        {
            get { return h; }
            set { h = value; }
        }

        public BigInteger X
        {
            get { return x; }
            set { x = value; }
        }

        public BigInteger Y
        {
            get { return y; }
            set { y = value; }
        }

        //Tạo khóa với số bit lớn
        public void generateKeyDSA(int bit)
        {
            q = utilities.GeneratePrimeNumber(bit -10);
            p = utilities.GeneratePrimeNumberIsMultiple(q, bit);
            h = utilities.GetRandomNumber(2, p - 2);
            do
            {
                g = BigInteger.ModPow(h, (p - BigInteger.One) / q, p);
            } while (g == BigInteger.One);

            x = utilities.GetRandomNumber(BigInteger.One, q - BigInteger.One);
            y = BigInteger.ModPow(g, x, p);
        }

        //Tạo khóa với số nguyên tố q lớn
        public void generateKeyDSA(BigInteger q)
        {
            this.q = q;
            p = utilities.GeneratePrimeNumberIsMultiple(q);
            h = utilities.GetRandomNumber(2, p - 2);
            do
            {
                g = BigInteger.ModPow(h, (p - BigInteger.One) / q, p);
            } while (g == BigInteger.One);

            x = utilities.GetRandomNumber(BigInteger.One, q - BigInteger.One);
            y = BigInteger.ModPow(g, x, p);
        }
        public void generateKeyDSA()
        {
            q = utilities.GeneratePrimeNumber();
            p = utilities.GeneratePrimeNumberIsMultiple(q);
            h = utilities.GetRandomNumber(2, p - 2);
            do
            {
                g = BigInteger.ModPow(h, (p - BigInteger.One) / q, p);
            } while (g == BigInteger.One);

            x = utilities.GetRandomNumber(BigInteger.One, q - BigInteger.One);
            y = BigInteger.ModPow(g, x, p);
        }

        public Dictionary<BigInteger, BigInteger> SigningMessage(string hashCode, BigInteger p, BigInteger q, BigInteger g, BigInteger x)
        {
            Dictionary<BigInteger, BigInteger> signature = new Dictionary<BigInteger, BigInteger>();
            BigInteger hashValue = SHA_1.HexToDecimal(hashCode);
            BigInteger k, r, s;

            do
            {
                k = utilities.GetRandomNumber(BigInteger.One, q - BigInteger.One);
                r = BigInteger.ModPow(g, k, p) % q;
                s = utilities.NghichDao(k, q) * (hashValue + (x * r) % q) % q;
            }
            while (r == BigInteger.Zero || s == BigInteger.Zero);

            signature.Add(r, s);

            return signature;
        }

        public bool VerifyingSignature(string hashCode, BigInteger r, BigInteger s, BigInteger p, BigInteger q, BigInteger g, BigInteger y)
        {
            bool check = false;

            if (r.CompareTo(BigInteger.Zero) == 1 && r.CompareTo(q) == -1 && s.CompareTo(BigInteger.Zero) == 1 && s.CompareTo(q) == -1)
            {
                BigInteger w = utilities.NghichDao(s, q);
                BigInteger hashValue = SHA_1.HexToDecimal(hashCode);
                BigInteger u1 = (hashValue * w) % q;
                BigInteger u2 = (r * w) % q;
                BigInteger gu1 = BigInteger.ModPow(g, u1, p);
                BigInteger yu2 = BigInteger.ModPow(y, u2, p);
                BigInteger v = ((gu1 * yu2) % p) % q;
                if (v.Equals(r))
                {
                    check = true;
                }
            }

            return check;
        }

    }
}

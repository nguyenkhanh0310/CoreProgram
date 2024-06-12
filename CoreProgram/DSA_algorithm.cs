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

        public void generateKeyDSA(int bit)
        {

        }
    }
}

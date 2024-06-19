using System;
using System.Numerics;
namespace CoreProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //int bit = 1024; // Example bit length
            DSA_algorithm d = new DSA_algorithm();
            string message1 = "Hello World!";

            //string text = "hello world";
            string hashString = SHA_1.SHA1(message1);
            //BigInteger decimalNumber = SHA_1.HexToDecimal(hashString);

            Console.WriteLine("Hash = " + hashString);
            //Console.WriteLine(decimalNumber);
            int bitlength = 1024;

            d.generateKeyDSA(bitlength);
            BigInteger q = d.Q;
            BigInteger p = d.P;
            BigInteger g = d.G;
            BigInteger x = d.X;
            //Console.WriteLine("Q=" + d.Q);
            //Console.WriteLine("P=" + d.P);
            //Console.WriteLine("G=" + d.G);
            //Console.WriteLine("H=" + d.H);
            //Console.WriteLine("X=" + d.X);
            //Console.WriteLine("Y=" + d.Y);
            //Dictionary<BigInteger, BigInteger> signature = d.SigningMessage(hashString, p, q, g, x);
            //foreach (var pair in signature)
            //{
            //    Console.WriteLine($"r: {pair.Key}, s: {pair.Value}");
            //}



            //d.generateKeyDSA(utilities.GeneratePrimeNumber());
            //BigInteger p = d.P;
            //BigInteger q = d.Q;
            //BigInteger g = d.G;
            //BigInteger x = d.X;
            //BigInteger y = d.Y;


            Dictionary<BigInteger, BigInteger> signature = d.SigningMessage(SHA_1.SHA1(message1), d.P, d.Q, d.G, d.X);

            BigInteger r = 0, s = 0;
            foreach (var entry in signature)
            {
                r = entry.Key;
                s = entry.Value;
            }
            Console.WriteLine("p = " + string.Format("{0:X}", d.P));
            Console.WriteLine("q = " + string.Format("{0:X}", d.Q));
            Console.WriteLine("g = " + string.Format("{0:X}", d.G));
            Console.WriteLine("x = " + string.Format("{0:X}", d.X));
            Console.WriteLine("y = " + string.Format("{0:X}", d.Y));
            Console.WriteLine("{r,s} = {" + string.Format("{0:X}", r) + ", " + string.Format("{0:X}", s) + "}");


            string message2 = "Hello World!";

            if (d.VerifyingSignature(SHA_1.SHA1(message2), r, s, d.P, d.Q, d.G, d.Y))
            {
                Console.WriteLine("SIGNATURE ACCEPTED!!");
            }
            else
            {
                Console.WriteLine("SIGNATURE REJECTED!!");
            }

        }
    }
}
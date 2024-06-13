// See https://aka.ms/new-console-template for more information
using CoreProgram;
using Org.BouncyCastle.Crypto.Generators;
using System.Globalization;
using System.Numerics;
class Program
{
    
    public static void Main()
    {
        //int bit = 1024; // Example bit length

        string text = "hello world";
        string hashString = SHA_1.SHA1(text);
        BigInteger decimalNumber = SHA_1.HexToDecimal(hashString);

        Console.WriteLine(hashString);
        Console.WriteLine(decimalNumber);
        int bitLength = 1024;

        DSA_algorithm d = new DSA_algorithm();
        d.generateKeyDSA();
        Console.WriteLine("Q="+d.Q);
        Console.WriteLine("P=" + d.P);
        Console.WriteLine("G="+d.G);
        Console.WriteLine("H="+d.H);
        Console.WriteLine("X=" + d.X);
        Console.WriteLine("Y=" + d.Y);

    }
}
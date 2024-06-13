// See https://aka.ms/new-console-template for more information
using CoreProgram;
using System.Numerics;
class Program
{
    public static void Main()
    {
        BigInteger a = 11;
        BigInteger n = 17;
        Console.WriteLine(utilities.NghichDao(a,n));
        int k = 20;
        if (utilities.IsPrime(n, k))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
        Console.WriteLine("ran = "+utilities.GetRandomNumber(2, n-1));
        BigInteger q = utilities.GeneratePrimeNumber();
        Console.WriteLine("q=" + q);

        Console.WriteLine("p= " + utilities.GeneratePrimeNumberIsMultiple(q));
    }
}
// See https://aka.ms/new-console-template for more information
using System;

namespace SHA // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }*/
        public static void Main()
        {
            string text = "laptrinhcsharp";
            string str_sha512 = SHA_test.SHA512(text);
            Console.WriteLine($"SHA512: {str_sha512}");
            string str_sha1 = SHA_test.SHA1(text);
            Console.WriteLine($"SHA1: {str_sha1}");
            string str_sha2 = SHA_test.GetHashString(text);
            Console.WriteLine($"SHA1: {str_sha2}");
        }
    }
}

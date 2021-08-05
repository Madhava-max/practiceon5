using System;

namespace consonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give a character you want to check");
            char var = Console.ReadKey().KeyChar;
            switch (var)
            {
                case 'a':
                    Console.WriteLine("\nthe variable given " +var+ " is vowel");
                    break;
                case 'e':
                    Console.WriteLine("\nthe variable given " + var + " is vowel");
                    break;
                case 'i':
                    Console.WriteLine("\nthe variable given " + var + " is vowel");
                    break;
                case 'o':
                    Console.WriteLine("\nthe variable given " + var + " is vowel");
                    break;
                case 'u':
                    Console.WriteLine("\nthe variable given " + var + " is vowel");
                    break;
                default :
                    Console.WriteLine("\nthe variable given " + var + " is consonant");
                    break;


            }
        }
    }
}

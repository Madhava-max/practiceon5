using System;

namespace harmonic
{
    class Program
    {
        static void Nthharmonicnumber(int n)
        {
            for(int i=1;i<=n;i++)
            {
                Console.Write("1/{0}+",i);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("give a number for nth term of a harmonic number");
            int number = int.Parse(Console.ReadLine());
            Nthharmonicnumber(number);
        }
    }
}

using System;

namespace harmonic
{
    class Program
    {
        static void Nthharmonicnumber(int n)
        {
            int num = 1;
            Console.WriteLine("the result is "+num+"/"+n);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("give a number for nth term of a harmonic number");
            int number = int.Parse(Console.ReadLine());
            Nthharmonicnumber(number);
        }
    }
}

using System;

namespace _2table
{
    class Program
    {
        static void Tableof2(int n)
        {
            int num = 1;
            for(int i=1;i<=n;i++)
            {
                num *= 2;
                Console.WriteLine("2 power of"+i+" = "+num);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("give a value up to which you need a table of 2");
            int number = int.Parse(Console.ReadLine());
            Tableof2(number);        }
    }
}

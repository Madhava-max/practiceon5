using System;

namespace leapyear
{
    class Program
    {
        static void FindingWhetherleapYear(int number)
        {
            if(number%400==0)
            {
                Console.WriteLine("the given is a leapyear");
            }
            if(number%4==0)
            {
                if(number%100==0)
                {
                    Console.WriteLine("the given is not a leapyear");
                }
                else
                    Console.WriteLine("the given is a leapyear");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the year number");
            int year = int.Parse(Console.ReadLine());
             FindingWhetherleapYear(year);
        }
    }
}

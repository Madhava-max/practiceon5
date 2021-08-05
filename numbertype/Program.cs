using System;

namespace numbertype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give the number   ");
            int number = int.Parse(Console.ReadLine());
            if(number%2==0)
            {
                Console.WriteLine("the number is even ");
            }
            else
            {
                Console.WriteLine("the number is odd ");
            }
        }
    }
}


     
    


using System;

namespace biggestof3
{
    class Program
    {
        static void biggestof3(int no1,int no2,int no3)
        {
            if(no1>=no2)
            {
                if(no1>=no3)
                {
                    if(no1==no3)
                    {
                        Console.WriteLine("no3 and no1 are bigger ");
                    }
                    else
                    Console.WriteLine("no1 is bigger ");
                   
                }
            }
            else if(no2>=no3)
            {
                if(no2>=no1)
                {
                    if(no2==no1)
                    {
                        Console.WriteLine("no1 and no2 are bigger ");
                    }
                    else
                    Console.WriteLine("no2 is bigger ");
                }
            }
            else if(no3 >= no1)
            {
                if (no3 >= no2)
                {
                    if(no3==no2)
                    {
                        Console.WriteLine("no3 and no2 are bigger ");
                    }
                    else
                    Console.WriteLine("no3 is bigger ");
                }
            }
            else
            {
                Console.WriteLine("all are equal ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("the 1st number is ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the 2nd number is ");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("the 3rd number is ");
            int no3 = int.Parse(Console.ReadLine());
            biggestof3(no1, no2, no3);

        }
    }
}

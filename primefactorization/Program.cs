using System;

namespace primefactorization
{
    class Program
    {
        static int checkPrime(int num)
        {
            for(int j = 2;j*j<=num;j++)
            {
                if(num%j==0)
                {
                    return 0;
                }
            }
            return 1;

             

        }
        static void Main(string[] args)
        {
            Console.WriteLine("give a number");
            int number = int.Parse(Console.ReadLine());
            for(int i=2;i<=number;i++)
            {
                if(number%i==0)
                {
                    int result = checkPrime(i);
                    if(result == 1)
                    {
                        Console.WriteLine(""+i);
                    }
                }
            }
        }
    }
}

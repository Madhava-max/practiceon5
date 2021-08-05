using System;

namespace swapping
{
    class Program
    {
        static void swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("the first number is "+a);
            Console.WriteLine("the first number is " + b);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("the first number is ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("the second number is ");
            int number2 = int.Parse(Console.ReadLine());
            swap(number1, number2);

        }
    }
}

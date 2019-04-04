using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a / b);
            Console.ReadKey();
        }
    }
}
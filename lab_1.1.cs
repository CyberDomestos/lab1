﻿using System;
namespace Program
{
    class app
    {
        static void Main()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(a + b, 2));
            Console.ReadKey();
        }
    }
}
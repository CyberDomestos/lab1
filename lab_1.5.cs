﻿using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Math.Pow(a / b, 3));
            Console.ReadLine();
        }
    }
}
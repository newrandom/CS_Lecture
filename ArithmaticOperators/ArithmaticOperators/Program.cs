﻿using System;

namespace ArithmaticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}");

            int b = a - 100;
            Console.WriteLine($"b : {b}");

            int c = b * 10;
            Console.WriteLine($"c : {c}");

            double d = c / 6.3;
            Console.WriteLine($"d : {d}");

            double e = c / 6;
            Console.WriteLine($"e : {e}");


            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");

        }
    }
}


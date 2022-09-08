using System;
using ConvertString;

namespace ConvertString
{
    public static class ConvertString
    {
        public static string Append(this string myString, string appendingString)
        {
            return myString + appendingString;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
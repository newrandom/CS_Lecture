using System;

namespace UserInput_sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==== string input 받기 ==== //
            //string yourName;
            //Console.WriteLine("What is your name?");

            //yourName = Console.ReadLine();

            //Console.WriteLine("Hello {0}", yourName);

            // ======== 숫자 Convert ======== //
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);
            double y;

            y = Convert.ToDouble(age);
            Console.WriteLine(y);

        }
    }
}


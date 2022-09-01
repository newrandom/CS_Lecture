using System;

namespace IfIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요 : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            // int number = Int32.Parse(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("0보타 큰 짝수.");
                else
                    Console.WriteLine("0보타 큰 홀수.");
            }
            else
            {
                Console.WriteLine("0보타 작거나 같은 수.");
            }
        }
    }
}


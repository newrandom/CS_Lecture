using System;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            //string result = (10 % 2) == 0 ? "짝수" : "홀수";
            //int result = Convert.ToInt32(Console.ReadLine());
            //string answer = (result % 2) == 0 ? "짝수" : "홀수";

            string answer = (Convert.ToInt32(Console.ReadLine()) % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(answer);
        }
    }
}


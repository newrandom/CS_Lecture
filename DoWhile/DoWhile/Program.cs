using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);       // 무조건 실행되는 절
            }
            while (i > 0);      // ; 은 필수로 붙여주어야 한다.

            do
            {
                Console.WriteLine("b) i : {0}", i--);       // 무조건 실행되는 절
            }
            while (i > 0);
        }
    }
}


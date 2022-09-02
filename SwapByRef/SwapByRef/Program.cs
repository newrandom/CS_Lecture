using System;

namespace SwapByRef
{
    class MainApp
    {
        static void Swap(ref int a , ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(ref x, ref y);

            Console.WriteLine($"x:{x}, y:{y}");

            //Swap(x, y);     // ref 를 사용하지 않으면 오류가 발생한다.
            //Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
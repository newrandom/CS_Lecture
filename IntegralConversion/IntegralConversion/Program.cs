using System;

namespace IntegralConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;        // sbyte의 최대값 127보다 1큰 수
            Console.WriteLine(x);

            sbyte y = (sbyte)x;     // 오버플로우가 발생한다. 
            Console.WriteLine(y);
        }
    }
}


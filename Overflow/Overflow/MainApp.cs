using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;
            byte b = byte.MaxValue;
            byte c = byte.MinValue;
            sbyte d = sbyte.MinValue;
            int e = int.MaxValue;

            Console.WriteLine($"uint의 최대값 : {a}");
            Console.WriteLine($"byte의 최대값 : {b}");
            Console.WriteLine($"byte의 최소값 : {c}");
            Console.WriteLine($"sbyte의 최소값 : {d}");
            Console.WriteLine($"int의 최대값 : {e}");

            //a = a + 1;
            a += 1;


            Console.WriteLine($"uint.MaxValue + 1의 값은 : {a}");
        }
    }
}


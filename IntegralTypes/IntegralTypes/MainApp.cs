using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -10;      // signed byte : 1바이트 음수 양수 (-128~127)
            byte b = 40;        // byte : 1바이트 양수 (0~255)

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;   // unsigned short : 2바이트 양수 (0~(2^16)-1)

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000;     // 0이 7개
            uint f = 3_0000_0000;   // 0이 8개, unsigned int: 4바이트 양수 (0~(2^32)-1)

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;   // 0이 11개
            ulong h = 200_0000_0000_0000_0000;     // 0이 18개, unsigned long : 8바이트 양수 (0~(2^64)-1)

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}


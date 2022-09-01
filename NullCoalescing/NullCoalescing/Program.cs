using System;

namespace NullCoalescing
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");
                                // num 은 null 이 맞으므로 0을 리턴

            num = 99;
            Console.WriteLine($"{num ?? 0}");
                                // num 은 null 이 아니므로 num을 리턴

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");
                                // str 은 null 이 맞으므로 Default를 리턴

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
                                // str 은 null 이 아니므로 str을 리턴

        }
    }
}


using System;
using static System.Console;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "김튼튼";
            int age = 23;
            WriteLine($"{name,-10}, {age:D3}");
            // -10 : 왼쪽에서 10칸을 만들고 오른쪽에서 채움
            // :D3 : Decimal, 3자리의 0을 만들, 맨 오른쪽에서부터 age를 채
            WriteLine("{0,-10}, {1:D5}", name, age);

            name = "박날씬";
            age = 30;
            WriteLine($"{name}, {age,-10:D3}");
            WriteLine("{0}, {1,-22:D5}", name, age);

            name = "이비실";
            age = 17;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년")}");
            //Write("{0}, ", name);
            //Write("{0}", age > 20 ? "성인" : "미성년");
            WriteLine("{0}, {1}", name, age > 20 ? "성인" : "미성년");
        }
    }
}


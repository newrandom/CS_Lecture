using System;
using static System.Console;

namespace StringFormatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);    // 총 다섯칸 중에 오른쪽에서 채워 들어감

            // X : 16진수
            WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);     // 총 8 칸 중에 오른쪽에서 채워 들어감

            // N : 숫자
            WriteLine("숫자 : {0:N}", 123456789);     // 그냥 쓰면 소수점이 남는다.
            WriteLine("숫자 : {0:N0}", 123456789);    // 자릿수 0 은 소수점 이하를 제거함

            // F : 고정소수점
            WriteLine("고정소수점 : {0:F}", 123.45);     // 기본은 소수점 3자리까지 출력
            WriteLine("고정소수점 : {0:F5}", 123.45);    // 소수점 5자리까지 출력

            // E : 공학용
            WriteLine("공학 : {0:E}", 123.456789);        // 1.23456789E+002 >> 7번째에서 반올림하여 나타냄
        }
    }
}


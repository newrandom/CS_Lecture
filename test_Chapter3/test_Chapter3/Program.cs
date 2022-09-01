using System;
using static System.Console;

namespace test_Chapter3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("사각형의 너비를 입력하세요.");
            string width = ReadLine();

            WriteLine("사각형의 높이를 입력하세요.");
            string height = ReadLine();

            // 사각형의 넓이를 계산하고
            // 출력하는 루틴을 추가하세요.
            int w = Convert.ToInt32(width);
            int h = Convert.ToInt32(height);
            // 사각형의 넓이는 가로 * 세로
            WriteLine("사각형의 넓이는 : {0} * {1} = {2}",w,h,w*h);       // format 방식
            WriteLine($"사각형의 넓이는 : {w} * {h} = {w * h}");          // 문자열 보간   
        }
    }
}


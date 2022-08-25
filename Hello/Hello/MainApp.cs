using System;
using static System.Console;

namespace Hello
{
    class MainApp
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)       // if args의 길이가 0일때, 즉 그냥 실행시켰을때의 조건문
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");  // 파일명 + args의 이용방법을 안내
                return;         // return으로 프로그램 종료
            }
                Console.WriteLine("Hello, {0}!", args[0]);
        }
    }
}
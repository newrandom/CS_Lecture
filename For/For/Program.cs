using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
                // int i = 0; : 초기화
                            // i < 5; : 조건식 - 해당 조건을 true하는 동안 반복실행, false가 나면 for 반복문은 끝난다.
                                // i++ : 반복식 - 매회 변수값에 해당 값을 더함
            {
                Console.WriteLine(i);
            }
        }
    }
}


using System;

namespace UsingParams
{
    class MainApp
    {
        static int Sum(params int[] args)       // 인수를 매개변수 배열에 받고
        {
            Console.Write("Summing... ");

            int sum = 0;

            for (int i=0; i<args.Length; i++)   // 매개변수 배열의 길이 (args.Length)보다 i의 값이 작을 때,
            {
                if (i > 0)      // i 의 값이 0, 즉 첫번째가 아닌 경우에	
                    Console.Write(", ");    // 해당 string을 옆에 붙인다 (Write)

                Console.Write(args[i]);     // args[i]의 값을 string에 붙임.

                sum += args[i];     // sum에 sum + args[i]의 값을 더하여 반환한다.
            }
            Console.WriteLine();    // 빈 줄을 하나 생성

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);     // 가변개수의 인수

            Console.WriteLine($"Sum : {sum}");
        }
    }
}
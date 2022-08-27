using System;

namespace UsingVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type: {0}, Value : {1}", c.GetType(), c);

            // ===== 반복문 ===== //
            var d = new int[] { 10, 20, 30 };
            Console.Write("Type : {0}, Value: ", d.GetType());  // 변수 d 의 데이터 타입을 나타내고
            foreach (var e in d)
                Console.Write("{0} ", e);       // 변수 e 는 배열 d 를 하나씩 돌면서 값을 나타냄
                                                // Write : 이어서 나타내고
                                                // WriteLine : 줄을 바꿔서 나타낸다.

            Console.WriteLine();
        }
    }
}


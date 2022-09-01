using System;

namespace test_chapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// ==== 1번 문제 ====
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //        Console.Write("*");

            //    Console.WriteLine();
            //}

            //// ==== 2번 문제 ====
            //for (int i = 5; i > 0; i--)
            //{
            //    for (int j = i; j > 0; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //// ==== 3-1 ====
            //int a = 1;
            //while (a <= 5)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    a++;
            //}

            //a = 5;
            //while (a > 0)
            //{
            //    for (int i = a; i > 0; i--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    a--;
            //}

            //// ==== 3-2 ====
            //a = 1;
            //do
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    a++;
            //}
            //while (a <= 5);

            //a = 5;
            //do
            //{
            //    for (int i = a; i > 0; i--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    a--;
            //}
            //while (a > 0);

            // ==== 4 ====
            Console.Write("반복 횟수를 입력하세요 : ");
            int count = Int32.Parse(Console.ReadLine());

            if (count <= 0)
            {
                Console.WriteLine("0보다 같거나 작은 숫자는 사용할 수 없습니다.");

                goto EXIT_PROGRAM;
            }

            else
            {
                //for (int i = 0; i < count; i++)
                //{
                //    for (int j = 0; j <= i; j++)
                //    {
                //        Console.Write("*");
                //    }
                //    Console.WriteLine();
                //}
                do
                {
                    for (int i = 0; i < count; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    count = 0;      // 음..........
                }
                while (count > 0);
            }

            EXIT_PROGRAM:
            Console.WriteLine("프로그램이 종료됩니다.");
        }
    }
}


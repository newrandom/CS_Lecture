using System;

namespace Ex6_2
{
    class MainApp
    {
        public static void Main()
        {
            double mean = 0;

            //mean = Mean(1, 2, 3, 4, 5, mean); // double 형식으로 mean을 받아왔을 때 반환 받을 변수

            //Mean(1, 2, 3, 4, 5, ref mean);
            //Mean(1, 2, 3, 4, 5, mean);        // double 형식으로 mean을 받아오고 이를 함수에 적용
            Mean(1, 2, 3, 4, 5, out mean);      // out 으로 받아와도 성공

            Console.WriteLine("평균 : {0}", mean);

        }

        // 참조 형식(ref)으로 mean 받아오는 방법
        //public static void Mean(
        //    double a, double b, double c, double d, double e, ref double mean)
        //{
        //    mean = (a + b + c + d + e) / 5;
        //}


        // double 형식으로 mean을 받아오는 방법
        //public static double Mean(
        //    double a, double b, double c, double d, double e, ref double mean)
        //{
        //    mean = (a + b + c + d + e) / 5;
        //    return mean;
        //}

        // out 으로 받기
        public static void Mean(
            double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
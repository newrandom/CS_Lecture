using System;

namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18   => 0.2,   // 학생이고 18세 미만일때
                ("학생", _)                   => 0.1,   // 학생이고 18세 이상일때 (_ : ? 모든 것 (?)을 나타내는건가 ?)
                ("일반", int n) when n < 18   => 0.1,       // 일반이고 18세 미만일 때
                ("일반", _)                   => 0.05,  // 일반이고 18세 이상일 때
                _                            => 0,     // 기본값은 0  
            };
        }

        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "일반", age: 15);
            var dave = (job: "일반", age: 21);
            var test = ("일반", 23);

            Console.WriteLine($"alice   : {GetDiscountRate(alice)}");
            Console.WriteLine($"bob     : {GetDiscountRate(bob)}");
            Console.WriteLine($"charlie : {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave    : {GetDiscountRate(dave)}");
            Console.WriteLine($"test    : {GetDiscountRate(test)}");


        }
    }
}
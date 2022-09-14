using System;

namespace PositionalPattern
{
    class MainApp
    {
        //private static double GetDiscountRate(object client)
        //{
        //    return client switch
        //    {
        //        ("학생", int n) when n < 18 => 0.2,
        //        ("학생", _) => 0.1,
        //        ("일반", int n) when n < 18 => 0.1,
        //        ("일반", _) => 0.05,
        //        _ => 0,
        //    };
        //}

        private static double GetDiscountRate(object client)
        {
            switch (client)
            {
                case ("학생", int n) when n < 18:
                    return 0.2;
                case ("학생", _):
                    return 0.1;
                case ("일반", int n) when n < 18:
                    return 0.1;
                case ("일반", _):
                    return 0.05;
                default:
                    return 0;

            }
        }

        static void Main(string[] args)
        {
            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);

            Console.WriteLine($"alice   : {GetDiscountRate(alice)}");

            Console.WriteLine($"bob     : {GetDiscountRate(bob)}");
        }
    }
}
using System;
using MyExtension;      // 확장메소드가 담긴 namespace를 불러오기 

namespace MyExtension
{
    public static class IntegerExtension        // 확장 메소드 static class class_name : static + class + class_name을 지정해주어야 한다.
    { 
        public static int Square(this int myInt)        // 확장메소드 : static type method_name(this changing_type variable) >> 
        {
        return myInt * myInt;
        }

        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * myInt;
            }
            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
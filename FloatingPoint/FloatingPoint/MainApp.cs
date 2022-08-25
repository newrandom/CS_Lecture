using System;

namespace FloatingPoint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846f;      // 직접 부동소수를 나타내고자 한다면 f 를 붙여주어야 한다.
            Console.WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            Console.WriteLine(b);
        }
    }
}


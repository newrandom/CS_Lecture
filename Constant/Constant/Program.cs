using System;

namespace Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX_INT = 2147483647;         // 상수선언 const (data_type) (variable_name) = value;
            const int MIN_INT = -2147483648;

            Console.WriteLine(MAX_INT);
            Console.WriteLine(MIN_INT);

            // ========== 상수를 변경하면 어떤일이 ? ======== //
            //const int a = 3;
            //a = 4;

            // 오류가 발생한다. 
        }
    }
}


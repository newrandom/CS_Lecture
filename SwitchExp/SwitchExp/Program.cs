using System;

namespace SwitchExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());
            // int score = Int32.Parse(Console.ReadLine());
            // int score = Int32.TryParse(Console.ReadLine());

            Console.WriteLine("재수강인가요? (y/n)");
            string line = Console.ReadLine();
            bool repeated = line == "y" ? true : false;     // 변수에 조건문을 넣어도 되는구나 !

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
                                // Math.Truncate(double d) : double 형식의 d 를 Truncate(소수점을 제하고) 하여 나타냄
            {
                90 when repeated == true => "B+",
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            Console.WriteLine($"학점 : {grade}");
        }
    }
}


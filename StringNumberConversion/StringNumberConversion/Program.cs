using System;

namespace StringNumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();        // 숫자를 string 형식으로 변환
            Console.WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "123456";
            int f = Convert.ToInt32(e);     // string 형식을 Int32 형식으로 변환
            Console.WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);       // string 형식을 float 형식으로 변환
            Console.WriteLine(h);

            string i = "3333";
            int j = int.Parse(i);           // string 형식을 int 형식으로 변환
            Console.WriteLine(j);
        }
    }
}


using System;

namespace CTS
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 a = 123;
            int b = 456;

            Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
            Console.WriteLine("b type:{0}, value:{1}", b.GetType(), b);     // .ToString() 을 안써도 데이터가 문자열로 출력은 되는것으로 보인다...
                                                                            // 근데 책에 나온대로 해야겠지?

            System.String c = "abc";
            string d = "def";

            Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
            Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);

        }
    }
}


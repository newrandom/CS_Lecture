using System;
using static System.Console;

namespace StringSlice
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            WriteLine(greeting.Substring(0, 5));        // "Good ",   python [0:5]
            WriteLine(greeting.Substring(5));   // "morning", python [5:]
            WriteLine();



            string test = "1234567890";
            WriteLine(test.Substring(0, 5));
            WriteLine(test.Substring(5));
            WriteLine();


            string[] arr = greeting.Split(      // arr 변수의 배열을 생성한다.
                new string[] { " " }, StringSplitOptions.None);
            // string.Split(new string[] {" "}, StringSplitOptions.None)
                    // Split(A, B) : A - 문자열을 나눌 특정 내용을 설정
                                //   B - Split Option 을 설정(?)

            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}


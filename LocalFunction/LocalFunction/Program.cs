using System;

namespace LocalFunction
{
    class MainApp
    {
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();  // .ToCharArray() : 문자 배열로 만들기
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)     // 대문자를 소문자로 변환하는 Local 함수
            {
                if (arr[i] < 65 || arr[i] > 90) // A~Z의 ASCII 값 : 65 ~ 90
                    return arr[i];      // A~Z의 값이 아니면 그냥 그대로 반환
                else    // a~z의 ASCII 값 : 97~ 122
                    return (char)(arr[i] + 32);     // A~Z의 값이면 32를 더해서 (char) type으로 변환하여 arr[i]에 반환
            }

            return new string(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
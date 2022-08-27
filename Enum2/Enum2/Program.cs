using System;

namespace Enum2
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;         // DialogResult 열거형식(데이터형식) 의 result 변수로 DialogResult.YES 를 할당.

            Console.WriteLine(result == DialogResult.YES);      // 여기만 True
            Console.WriteLine(result == DialogResult.NO);       // 나머지는 False를 반환한다.
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);

        }
    }
}


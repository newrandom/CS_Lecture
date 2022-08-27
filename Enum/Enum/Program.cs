using System;

namespace Enum
{
    class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }      // enum 열거형식, enum (열겨형식명) (자료형 - int, sint 등의 정수) { item0, item1, ... }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

        }
    }
}


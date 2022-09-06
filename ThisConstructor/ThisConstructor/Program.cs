using System;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c, d;

        public MyClass()
        {
            this.a = 5425;
            Console.WriteLine("MyClass()");
        }

        public MyClass(int b) : this()      // MyClass 를 호출
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }

        public MyClass(int b, int c , int d):this(b,c)
        {
            this.d = d;
            Console.WriteLine($"MyClass({b}, {c}, {d})");
        }

        public void PrintFields()
        {
            Console.WriteLine($"a:{a}, b:{b}, c:{c}, d:{d}");
        }

    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            Console.WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            Console.WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
            Console.WriteLine();

            MyClass d = new MyClass(50, 60, 70);
            d.PrintFields();
        }
    }
}
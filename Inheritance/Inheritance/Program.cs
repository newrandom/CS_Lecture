using System;

namespace Inheritance
{
    class Base
    //sealed class Base       // sealed : 클래스를 상속하지 못하도록 봉인! 
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        ~Base()     // 종료자는 출력될수도 되지 않을수도 있다.
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived");
        }

        public void DerivedMethod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");     // Base.Base(string Name), 호출과 동시에 해당 메소드의 기능이 작동함 
            a.BaseMethod();

            Derived b = new Derived("b");       // Derived.Derived(string Name), 호출과 동시에 해당 메소드의 기능이 작동함 
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}


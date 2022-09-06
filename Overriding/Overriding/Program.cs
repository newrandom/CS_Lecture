using System;

namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initialize()        // virtual ***
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initialize()       // override ***
        {
            base.Initialize();                  // override 를 선언하면 자동으로 입력된다.
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating ArmorSuite ... ");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initialize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();

            Console.WriteLine("\nCreating WarMachine...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initialize();


            // 상위, 하위(동일), 하위(다른) 클래스 상속 비
            Console.WriteLine();
            ArmorSuite test1 = new WarMachine();        // 상위 클래스 < 하위클래스 (상위클래스 타입을 따를 때 ) == 성립
            WarMachine test = new WarMachine();     // 하위 클래스 < 하위클래스 (동일한 클래스)  == 성립
            //WarMachine test2 = new IronMan();       // 하위 클래스 < 다른 하위클래스 == 성립하지 않음
            test1.Initialize();
            Console.WriteLine();
            test.Initialize();
        }
    }
}
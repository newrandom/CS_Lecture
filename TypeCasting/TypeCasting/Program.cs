﻿using System;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }


    class MainApp
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            // ========================= //
            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;       // mammal2 가 Cat 과 형식이 같으면 할당, 아니면 Null
            if (cat != null)
            {
                cat.Meow();
            }

            // ========================== //
            Cat cat2 = mammal as Cat;       // mammal = new Dog(); / Dog != Cat
            if (cat2 != null)
            {
                cat2.Meow();
            }
            else
            {
                Console.WriteLine("cat2 is not a Cat");
            }
        }
    }
}
using System;
using System.Linq.Expressions;

namespace RecordComp
{
    class CTransaction
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    record RTransaction
    {
        public string From { get; init; }

        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trb = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(trA);
            Console.WriteLine(trb);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trb)}");

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");

        }
    }
}
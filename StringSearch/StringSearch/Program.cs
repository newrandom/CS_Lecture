using static System.Console;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));
            WriteLine("IndexOf 'Morning' : {0}", greeting.IndexOf("Morning"));

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));
            WriteLine("LastIndexOf 'Morning' : {0}", greeting.LastIndexOf("Morning"));

            // StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));
            WriteLine("StartsWith 'G' : {0}", greeting.StartsWith('G'));

            // EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));
            WriteLine("EndsWith 'g' : {0}", greeting.EndsWith('g'));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));
            WriteLine("Contains 'g' : {0}", greeting.Contains('g'));
            WriteLine("Contains 'z' : {0}", greeting.Contains('z'));

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening' : {0}",
                greeting.Replace("Morning", "Evening"));

        }
    }
}


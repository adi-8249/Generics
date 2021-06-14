using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics program");
            FindMaximum find = new FindMaximum();
            Console.WriteLine(find.MaxNumber(10,20,30));
        }
    }
}

using System;

namespace MyConsoleApp
{
    public class MyProgram
    {
        public int Add(int aa, int bb) => aa + bb;
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the first number:");
            var a = Convert.ToInt32(Console.ReadLine().ToString());
            Console.WriteLine("Enter the second number:");
            var b = Convert.ToInt32(Console.ReadLine().ToString());
            var result = new MyProgram().Add(a, b);
            Console.WriteLine($"Result of Add({a}, {b}) is {result}");
        }
    }
}

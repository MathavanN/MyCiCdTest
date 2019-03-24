using System;

namespace MyConsoleApp
{
    public class MyProgram
    {
        public string Get(int left, int right) => $"{left + right}";
    }

    public class Program
    {
        public static void Main()
        {
            var a = 5;
            var b = 6;
            var result = new MyProgram().Get(a, b);
            Console.WriteLine($"Result of Get({a}, {b}) is {result}");
        }
    }
}

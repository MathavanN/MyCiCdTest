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
            var result = new MyProgram().Get(5, 5);
            Console.WriteLine(result);
        }
    }
}

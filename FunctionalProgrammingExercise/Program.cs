using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> names = x => Console.WriteLine($"{string.Join(Environment.NewLine, x)}");
            Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .ToList()
                        .ForEach(names);
        }
    }
}

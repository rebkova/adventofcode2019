using System;

namespace Day0_CSharp8Explore
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = default;
            Console.WriteLine(a ?? "what?!");
        }
    }
}

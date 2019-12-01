using System;
using System.Collections.Generic;
using SantasToolbox;

namespace _1_Fuel
{
    class Program
    {
        private static void Main(string[] args)
        {
            using var inputProvider = new InputProvider<int>("Input.txt", int.TryParse);

            //Debug example:
            //Part1(new List<int>{ 1, 23, 12312 }.GetEnumerator());

            //Part1(inputProvider);
            Part1(new List<int> { 12, 661, 213 }.GetEnumerator());

            //inputProvider.Reset();

            //Part2(inputProvider);
        }

        private static void Part1(IEnumerator<int> inputProvider)
        {
            while (inputProvider.MoveNext())
            {
                int x = inputProvider.Current;

                Console.WriteLine(x);
            }
        }

        private static void Part2(IEnumerator<int> inputProvider)
        {

        }

    }
}

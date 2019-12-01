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
            //Part1(new List<int> { 12, 14, 1969, 100756 }.GetEnumerator());

            inputProvider.Reset();

            Part2(inputProvider);
            //Part2(new List<int> { 1969 }.GetEnumerator());
        }

        private static void Part1(IEnumerator<int> inputProvider)
        {

            int sum = 0;
         
            while (inputProvider.MoveNext())
            {
                int x = inputProvider.Current;
                sum = sum + (x / 3 - 2);    

            }

            Console.WriteLine(sum);
        }


        private static void Part2(IEnumerator<int> inputProvider)
        {
            int sum = 0;
            while (inputProvider.MoveNext())
            {
                int x = inputProvider.Current;

                while (x > 0)
                {
                    x = x / 3 - 2;

                    if (x > 0)
                    {
                        sum = sum + x;
                        //Console.WriteLine(x);
                    }
                    
                }

                
            }

            Console.WriteLine(sum);
        }

    }
}

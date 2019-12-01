using System;
using SantasToolbox;

namespace _1_Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputProvider = new InputProvider<int>("Input.txt", int.TryParse);

            int totalMass = 0;

            while (inputProvider.MoveNext())
            {
                int mass = inputProvider.Current;

                totalMass += (int)(Math.Floor(mass / 3.0) - 2);
            }

            Console.WriteLine($"Total mass Required: {totalMass}");
        }
    }
}

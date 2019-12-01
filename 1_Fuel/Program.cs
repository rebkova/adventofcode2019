using System;
using SantasToolbox;

namespace _1_Fuel
{
    class Program
    {
        private static void Main(string[] args)
        {
            using var inputProvider = new InputProvider<int>("Input.txt", int.TryParse);

            int totalMass = 0;
            int totalFuelMass = 0;
            bool requiresFuelForfuel = true;

            while (inputProvider.MoveNext())
            {
                int mass = inputProvider.Current;
                
                var fuelMass = GetFuelMassForModule(requiresFuelForfuel, mass);
                totalFuelMass += fuelMass;
                totalMass += mass + fuelMass;
            }

            Console.WriteLine($"Total mass Required: {totalMass}, of which {totalFuelMass} is Fuel");
        }

        private static int GetFuelMassForModule(bool requiresFuelForfuel, int mass)
        {
            int fuelMass = GetFuelRequired(mass);
            int totalFuelMass = fuelMass;

            if (requiresFuelForfuel)
            {
                while (true)
                {
                    int addFuelMass = GetFuelRequired(fuelMass);

                    if (addFuelMass <= 0) break;

                    totalFuelMass += addFuelMass;
                    fuelMass = addFuelMass;
                }
            }

            return totalFuelMass;
        }

        private static int GetFuelRequired(int mass)
        {
            return (int)(Math.Floor(mass / 3.0) - 2);
        }
    }
}

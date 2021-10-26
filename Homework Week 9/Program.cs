using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer tripA = new Odometer();
            tripA.Add(100,6);
            tripA.Add(14, 1);
            Console.WriteLine(tripA.ToString());
            Odometer tripB = new Odometer(11,2);
            tripB.Add(35,3);
            tripB.Add(28,3);
            Console.WriteLine(tripB.ToString());
            tripA.Reset();
            tripA.Add(312, 12);
            Console.WriteLine(tripA.ToString());
            Console.Read();
        }
    }

    class Odometer
    {
        int miles_driven;
        double fuel_used;

        public Odometer()
        {
            miles_driven = 0;
            fuel_used = 0;
        }

        public Odometer(int miles_gone, double gas_used)
        {
            miles_driven = miles_gone;
            fuel_used = gas_used;
        }

        public void Reset()
        {
            miles_driven = 0;
            fuel_used = 0;
        }

        public void Add(int add_miles, double add_fuel)
        {
            if (add_miles < 0 || add_fuel < 0)
                return;

            miles_driven += add_miles;
            fuel_used += add_fuel;
        }

        public double GetMilesPerGallon()
        {
            return miles_driven / fuel_used;
        }

        public override string ToString()
        {
            return "You have driven " + miles_driven + " miles, using " + fuel_used + " gallons of gas, meaning you got " + GetMilesPerGallon() + " miles per gallon.";
        }
    }
}

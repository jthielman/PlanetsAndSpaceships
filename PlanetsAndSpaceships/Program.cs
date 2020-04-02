using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            Console.WriteLine(String.Join(", ", planetList));

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            Console.WriteLine(String.Join(", ", planetList));

            var otherTungelList = new List<string>() { "Neptune", "Uranus" };

            planetList.AddRange(otherTungelList);

            Console.WriteLine(String.Join(", ", planetList));

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            Console.WriteLine(String.Join(", ", planetList));

            planetList.Add("Pluto");

            Console.WriteLine(String.Join(", ", planetList));

            var rockyPlanets = planetList.GetRange(0, 4);

            Console.WriteLine(String.Join(", ", rockyPlanets));

            planetList.Remove("Pluto");

            Console.WriteLine(String.Join(", ", planetList));
            Console.WriteLine("Wait, where's Pluto? That's messed up.");
        }
    }
}

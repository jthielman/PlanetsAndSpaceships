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

            Console.WriteLine(String.Join(", ", rockyPlanets) + " are the rocky planets");

            planetList.Remove("Pluto");

            Console.WriteLine(String.Join(", ", planetList));
            Console.WriteLine("Wait, where's Pluto? That's messed up.");

            var spaceships = new Dictionary<string, List<string>>
            {
                { "Mariner 10", new List<string> { "Mercury", "Venus", "Earth" } },
                { "Opportunity", new List<string> { "Mars" } },
                { "Voyager 1", new List<string> { "Earth", "Jupiter", "Saturn" } },
                { "Voyager 2", new List<string> { "Earth", "Jupiter", "Saturn", "Uranus", "Neptune" } }
            };

            var ships = spaceships.Keys;
            Console.WriteLine(String.Join(", ", ships));

            foreach (var planet in planetList)
            {
                var listOfShips = new List<string>();

                foreach (var ship in ships)
                {
                    var planetsVisited = spaceships.GetValueOrDefault(ship);
                    if (planetsVisited.Contains(planet))
                    {
                        listOfShips.Add(ship);
                    }
                }

                Console.WriteLine($"{planet}: {String.Join(", ", listOfShips)}");
            }
        }
    }
}

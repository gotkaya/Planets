using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Planetss
{
    class Program
    {

        public class Planets
        {
            string name;
            int mass;

            public Planets(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
                Console.WriteLine($"Planets:{name} created.");
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
        }
        static void Main(string[] args)
        {
            ReadfromPlanetlist();
        }

        public static void ReadfromPlanetlist()
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"Planets.txt";
            

            List<Planets> PlanetsItem = new List<Planets>();

            List<string> LinesFromFile = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();

            foreach (string line in LinesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Planets newPlanets = new Planets(tempArray[0], Int32.Parse(tempArray[1]));
                PlanetsItem.Add(newPlanets);
            }
            Console.WriteLine("Your Planets:");

            int total = 0;
            foreach (Planets planets in PlanetsItem)
            {
                Console.WriteLine($"Planets:{planets.Name}; Mass:{planets.Mass}");
                total += planets.Mass;
            }

            Console.WriteLine(total);
        }
    }
}

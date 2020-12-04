using System;
using System.Collections.Generic;
using System.IO;

namespace Planetslist
{
    class Program
    {
         public class Item
         {
            string name;
            int mass;

            public Item(string _name, int _mass)
            {
                name = _name;
                mass = _mass;
            }

            public string Name { get { return name; } }
            public int Mass { get { return mass; } }
         }
        static void Main(string[] args)
        {
            WritePlanetList();
        }

        public static void WritePlanetList()
        {
            List<string> Planetlist = new List<string>();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("enter planet:");
                string planet = Console.ReadLine();
                Console.WriteLine("enter mass:");
                string mass = Console.ReadLine();

                string line = $"{planet}/{mass}";
                Planetlist.Add(line);
            }

            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"Planets.txt";
            File.WriteAllLines(Path.Combine(filePath, fileName), Planetlist);
        }
    }
}

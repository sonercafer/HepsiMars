using HepsiMarsApp.Enums;
using HepsiMarsApp.Models;
using System;

namespace HepsiMarsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRover = new RoverVehicle(1, 2, Direction.N, new Plateau(5, 5));
            var firstResult = firstRover.Process("LMLMLMLMM");
            Console.WriteLine(firstResult);

            var secondRover = new RoverVehicle(3, 3, Direction.E, new Plateau(5, 5));
            var secondResult = secondRover.Process("MMRMMRMRRM");
            Console.WriteLine(secondResult);
            Console.ReadKey();
        }
    }
}

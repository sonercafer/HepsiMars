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
            firstRover.Command("LMLMLMLMM");
            firstRover.WritePosition();

            var secondRover = new RoverVehicle(3, 3, Direction.E, new Plateau(5, 5));
            secondRover.Command("MMRMMRMRRM");
            secondRover.WritePosition();

            Console.ReadKey();
        }
    }
}

using HepsiMarsApp.Enums;
using HepsiMarsApp.Models;
using System;

namespace HepsiMarsApp
{
    public class RoverVehicle
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        Direction RoverDirection { get; set; }
        Plateau Plateau { get; set; }
        
        public RoverVehicle(int x, int y, Direction direction, Plateau plateau)
        {
            PositionX = x;
            PositionY = y;
            RoverDirection = direction;
            Plateau = plateau;
        }
         
        private void Move()
        {
            if (RoverDirection == Direction.N && Plateau.y > PositionY)
            {
                PositionY++;
            }
            else if (RoverDirection == Direction.E && Plateau.x > PositionX)
            {
                PositionX++;
            }
            else if (RoverDirection == Direction.S && PositionY > 0)
            {
                PositionY--;
            }
            else if (RoverDirection == Direction.W && PositionX > 0)
            {
                PositionX--;
            }
        }
        private void TurnLeft90Degress()
        {
            RoverDirection = (RoverDirection - 1) < Direction.N ? Direction.W : RoverDirection - 1;
        }

        private void TurnRight90Degress()
        {
            RoverDirection = (RoverDirection + 1) > Direction.W ? Direction.N : RoverDirection + 1;
        } 
         
        public string Process(string commandStr)
        {
            foreach (var character in commandStr.ToUpper())
            {
                switch (character)
                {
                    case ('L'):
                        TurnLeft90Degress();
                        break;
                    case ('R'):
                        TurnRight90Degress();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException($"Invalid character: {character}");
                }
            }

            return $"{PositionX} {PositionY} {RoverDirection}";
        }  
    }
}

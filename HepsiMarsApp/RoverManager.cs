using HepsiMarsApp.Enums;
using HepsiMarsApp.Models;
using System;

namespace HepsiMarsApp
{
    public class RoverManager
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        Direction RoverDirection { get; set; }
        Plateau Plateau { get; set; }
        
        public RoverManager(int x, int y, Direction direction, Plateau plateau)
        {
            PositionX = x;
            PositionY = y;
            RoverDirection = direction;
            Plateau = plateau;
        }
         
        private void Go()
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
        private void ChangeDirection(Char directionCode)
        {
            if (directionCode == 'L')
                RoverDirection = (RoverDirection - 90) < Direction.N ? Direction.W : RoverDirection - 90;
            else if (directionCode == 'R')
                RoverDirection = (RoverDirection + 90) > Direction.W ? Direction.N : RoverDirection + 90;
        }
         
        public void Command(string commandStr)
        {
            foreach (var command in commandStr)
            {
                if (command == 'L' || command == 'R')
                    ChangeDirection(command);
                else if (command == 'M')
                    Go();
            }
        } 
        public void WritePosition()
        {
            string roverPosition = string.Format("{0} {1} {2}", PositionX, PositionY, RoverDirection);
            Console.WriteLine(roverPosition);
        }
    }
}

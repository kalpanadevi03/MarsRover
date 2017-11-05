using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.BusinessLogic.Rover.Impl
{
    public class Rover : IRover
    {
        public IPosition RoverPosition { get; set; }
        public Orientations RoverOrientation { get; set; }
        public IPlateau RoverPlateau { get; set; }
               
        public void SetPosition(string positionCoordinates)
        {
            var position = positionCoordinates?.Split(' ').ToArray();
            RoverPosition.X = position != null && position.Length > 1 ? int.Parse(position[0]) : 0;
            RoverPosition.Y = position != null && position.Length > 1 ? int.Parse(position[1]) : 0;
            char direction = position[2] != null ? char.Parse(position[2]) : ' ';
            switch (direction)
            {
                case ('N'):
                    RoverOrientation = Orientations.N;
                    break;
                case ('E'):
                    RoverOrientation = Orientations.E;
                    break;
                case ('S'):
                    RoverOrientation = Orientations.S;
                    break;
                case ('W'):
                    RoverOrientation = Orientations.W;
                    break;
                default:
                    RoverOrientation = Orientations.N;
                    break;
            }
        }


        public void Process(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", command));
                }
            }
        }
        public void TurnLeft()
        {
            RoverOrientation = (RoverOrientation - 1) < Orientations.N ? Orientations.W : RoverOrientation - 1;
        }

        public void TurnRight()
        {
            RoverOrientation = (RoverOrientation + 1) > Orientations.W ? Orientations.N : RoverOrientation + 1;
        }

        public void Move()
        {
            if (RoverOrientation == Orientations.N)
            {
                RoverPosition.Y++;
            }
            else if (RoverOrientation == Orientations.E)
            {
                RoverPosition.X++;
            }
            else if (RoverOrientation == Orientations.S)
            {
                RoverPosition.Y--;
            }
            else if (RoverOrientation == Orientations.W)
            {
                RoverPosition.X--;
            }
        }
    }
}

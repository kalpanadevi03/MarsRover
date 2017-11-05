using MarsRover.BusinessLogic.Rover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverApp
    {
        IRover _rover;
        public RoverApp(IRover rover, IPlateau roverPlateau, IPosition roverPosition)
        {
            _rover = rover;
            _rover.RoverPosition = roverPosition;
            _rover.RoverPlateau = roverPlateau;
        }
        public void Run()
        {
            try
            {
                string anotherRover;
                Console.WriteLine("Enter the size of the Plateau:");
                string plateau = Console.ReadLine();
                var plateauCoordinates = plateau != null ? plateau.Split(' ').ToArray() : null;
                _rover.RoverPlateau.XMax = plateauCoordinates != null ? int.Parse(plateauCoordinates[0]) : 0;
                _rover.RoverPlateau.YMax = plateauCoordinates != null ? int.Parse(plateauCoordinates[1]) : 0;

                do
                {
                    Console.WriteLine("Enter the inputs for Rover Position and direction:");
                    var position = Console.ReadLine();
                    _rover.SetPosition(position);

                    Console.WriteLine("Enter the Rover commands:");
                    string commands = Console.ReadLine();
                    _rover.Process(commands);
                    Console.WriteLine(_rover.RoverPosition.X.ToString() + ' ' + _rover.RoverPosition.Y.ToString() + ' ' + _rover.RoverOrientation.ToString());
                    Console.WriteLine("Do you want to deploy another Rover? (Y/N)");
                    anotherRover = Console.ReadLine();
                } while (anotherRover.ToLower() == "y");
            }
            catch
            {
                //to do - log the exception 
                Console.WriteLine("Invalid Input. Please enter the coordinates seperated by space");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.BusinessLogic.Rover
{
    public interface IRover
    {
        IPosition RoverPosition { get; set; }
        IPlateau RoverPlateau { get; set; }
        Orientations RoverOrientation { get; set; }
        void Process(string commands);
        void TurnLeft();
        void TurnRight();
        void Move();
        void SetPosition(string positionCoordinates);
    }
}

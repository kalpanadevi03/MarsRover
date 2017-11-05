using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.BusinessLogic.Rover.Impl
{
    public class Position : IPosition
    {
        public int X
        {
            get; set;
        }

        public int Y
        {
            get;
            set;
        }
    }
}

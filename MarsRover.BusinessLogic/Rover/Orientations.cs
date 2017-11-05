using MarsRover.BusinessLogic.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.BusinessLogic.Rover
{
    public enum Orientations
    {
        [StringValue("N")]
        N = 1,
        [StringValue("E")]
        E = 2,
        [StringValue("S")]
        S = 3,
        [StringValue("W")]
        W = 4
    }
}

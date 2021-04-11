using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Exceptions
{
    public class RoverCollisionException : Exception
    {
        public RoverCollisionException(int ID, string crashPoint) : base(String.Format("Another Rover is on the way for RoverID: {0} Crash point: {1}" ,ID, crashPoint))
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Exceptions
{
    public class DirectionChangeException : Exception
    {
        public DirectionChangeException() : base(String.Format("Rover's Direction could not be changed!"))
        {

        }
    }
}

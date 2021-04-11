using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Exceptions
{
    [Serializable]
    public class GridOutOfBoundsException : Exception
    {
        public GridOutOfBoundsException() : base(String.Format("Rover is out of grid. Simulation ended!"))
        {

        }
    }
}

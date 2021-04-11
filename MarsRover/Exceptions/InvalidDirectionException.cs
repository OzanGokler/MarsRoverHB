using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Exceptions
{
    public class InvalidDirectionException : Exception
    {
        public InvalidDirectionException() : base(String.Format("Invalid Direction!"))
        {

        }
    }
}

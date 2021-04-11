using MarsRover.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IRoverService
    {
        ResponseDTO MoveNorth(Rover rover);
        ResponseDTO MoveSouth(Rover rover);
        ResponseDTO MoveEast(Rover rover);
        ResponseDTO MoveWest(Rover rover);
        ResponseDTO ChangeDirection(Rover rover, char direction);
    }
}

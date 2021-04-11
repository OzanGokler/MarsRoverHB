using MarsRover.DTOs;
using MarsRover.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class RoverService : IRoverService
    {
        /// <summary>
        /// Rover'ı Kuzey'e bir birim ilerletir
        /// </summary>
        /// <param name="rover"></param>
        public ResponseDTO MoveNorth(Rover rover)
        {
            ResponseDTO dto = new ResponseDTO();
            try
            {
                rover.Y += 1;
                dto.IsSuccess = true;
                dto.Message = "Rover move 1 unit to North.";
            }
            catch (Exception e)
            {
                dto.IsSuccess = false;
                dto.Message = e.ToString();
            }

            return dto;
        }

        /// <summary>
        /// Rover'ı Guney'e bir birim ilerletir
        /// </summary>
        /// <param name="rover"></param>
        public ResponseDTO MoveSouth(Rover rover)
        {
            ResponseDTO dto = new ResponseDTO();
            try
            {
                rover.Y -= 1;
                dto.IsSuccess = true;
                dto.Message = "Rover move 1 unit to South.";
            }
            catch (Exception e)
            {
                dto.IsSuccess = false;
                dto.Message = e.ToString();
            }
            return dto;
        }

        /// <summary>
        /// Rover'ı Doğu'ya bir birim ilerletir
        /// </summary>
        /// <param name="rover"></param>
        public ResponseDTO MoveEast(Rover rover)
        {
            ResponseDTO dto = new ResponseDTO();
            try
            {
                rover.X += 1;
                dto.IsSuccess = true;
                dto.Message = "Rover move 1 unit to East.";
            }
            catch (Exception e)
            {
                dto.IsSuccess = false;
                dto.Message = e.ToString();
            }
            return dto;
        }

        /// <summary>
        /// Rover'ı Batı'ya bir birim ilerletir
        /// </summary>
        /// <param name="rover"></param>
        public ResponseDTO MoveWest(Rover rover)
        {
            ResponseDTO dto = new ResponseDTO();
            try
            {
                rover.X -= 1;
                dto.IsSuccess = true;
                dto.Message = "Rover move 1 unit to West";
            }
            catch(Exception e)
            {
                dto.IsSuccess = false;
                dto.Message = e.ToString();
            }
            return dto;
        }


        /// <summary>
        /// Rover'ın baktığı yönü değiştirir.
        /// </summary>
        /// <param name="rover"></param>
        /// <param name="direction"></param>
        public ResponseDTO ChangeDirection(Rover rover, char direction)
        {
            ResponseDTO dto = new ResponseDTO();
            if (direction == 'L')
            {
                ChangeDirectionLeft(rover);
            }
            else if (direction == 'R')
            {
                ChangeDirectionRight(rover);
            }
            dto.IsSuccess = true;
            dto.Message ="Direction is: " + rover.Direction;

            return dto;
        }

        private void ChangeDirectionLeft(Rover rover)
        {
            if (rover.Direction == MarsRover.Direction.East)
            {
                rover.Direction = MarsRover.Direction.North;
            }
            else if (rover.Direction == MarsRover.Direction.North)
            {
                rover.Direction = MarsRover.Direction.West;
            }
            else if (rover.Direction == MarsRover.Direction.West)
            {
                rover.Direction = MarsRover.Direction.South;
            }
            else if (rover.Direction == MarsRover.Direction.South)
            {
                rover.Direction = MarsRover.Direction.East;
            }
            else
            {
                throw new DirectionChangeException();
            }
        }

        private void ChangeDirectionRight(Rover rover)
        {
            if (rover.Direction == MarsRover.Direction.East)
            {
                rover.Direction = MarsRover.Direction.South;
            }
            else if (rover.Direction == MarsRover.Direction.South)
            {
                rover.Direction = MarsRover.Direction.West;
            }
            else if (rover.Direction == MarsRover.Direction.West)
            {
                rover.Direction = MarsRover.Direction.North;
            }
            else if (rover.Direction == MarsRover.Direction.North)
            {
                rover.Direction = MarsRover.Direction.East;
            }
            else
            {
                throw new DirectionChangeException();
            }
        }
    }
}

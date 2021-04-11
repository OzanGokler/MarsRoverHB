using MarsRover.DTOs;
using MarsRover.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class GridService : IGridServise
    {
        private RoverService RoverService = new RoverService();

        /// <summary>
        /// Start Simulate
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public ResponseDTO SimulateGrid(Grid grid)
        {
            ResponseDTO dto = new ResponseDTO();
            var Rovers = grid.GetRovers();
            foreach (var rover in Rovers)
            {
                for (int i = 0; i < rover.MoveList.Count; i++)
                {
                    if (rover.MoveList[i] == 'L' || rover.MoveList[i] == 'R')
                    {
                        RoverService.ChangeDirection(rover, rover.MoveList[i]);
                    }
                    else if (rover.MoveList[i] == 'M')
                    {
                        if (CheckRoverCollision(rover, Rovers))
                        {
                            MakeMove(rover, grid);
                        }                   
                        if (!CheckGridBounds(grid, rover))
                        {
                            throw new GridOutOfBoundsException();
                        }
                    }
                    else
                    {
                        throw new InvalidDirectionException();
                    }
                   
                }          
            }
            dto.IsSuccess = true;
            dto.Message = "Success";
            return dto;
        }


        private void MakeMove(Rover rover, Grid grid)
        {
            if (rover.Direction == Direction.North)
            {
                RoverService.MoveNorth(rover);                
            }
            else if (rover.Direction == Direction.East)
            {
                RoverService.MoveEast(rover);
            }
            else if (rover.Direction == Direction.West)
            {
                RoverService.MoveWest(rover);
            }
            else if (rover.Direction == Direction.South)
            {
                RoverService.MoveSouth(rover);
            }         
        }

        public bool CheckRoverCollision(Rover rover, List<Rover> rovers)
        {
            if (rovers.Exists(x => x.ID != rover.ID && x.X == rover.X && x.Y == rover.Y))
            {
                throw new RoverCollisionException(rover.ID,"X=" + rover.X + " Y=" + rover.Y);
            }
            return true;
        }

        private bool CheckGridBounds (Grid grid, Rover rover)
        {
            if (rover.X > grid.GetWidth() || rover.X < 0 || rover.Y > grid.GetLenght() || rover.Y < 0 )
            {
                return false;
            }
            return true;
        }
    }
}

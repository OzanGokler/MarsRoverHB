using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public Rover()
        {

        }

        public Rover (int ID, int X, int Y, Direction Direction, List<char> MoveList)
        {
            this.X = X;
            this.Y = Y;
            this.Direction = Direction;
            this.MoveList = MoveList;
            this.ID = ID;
        }

        public int ID { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public List<char> MoveList = new List<char>();

    }
}

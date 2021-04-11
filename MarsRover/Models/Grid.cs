using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Grid
    {
        public Grid(int Length, int Width, List<Rover> Rovers)
        {
            this.Length = Length;
            this.Width = Width;
            this.Rovers = Rovers;
        }

        private int Length { get; set; }

        private int Width { get; set; }

        private List<Rover> Rovers { get; set; }


        /// <summary>
        /// Return Grid Lenght.
        /// </summary>
        /// <returns>Length</returns>
        public int GetLenght()
        {
            return this.Length;
        }

        /// <summary>
        /// Set Grid Length.
        /// </summary>
        /// <param name="Length"></param>
        public void SetLenght(int Length)
        {
            this.Length = Length;
        }

        /// <summary>
        /// Return Grid Width.
        /// </summary>
        /// <returns>Width</returns>
        public int GetWidth()
        {
            return this.Width;
        }

        /// <summary>
        /// Set Grid Widht.
        /// </summary>
        /// <param name="Width"></param>
        public void SetWidth(int Width)
        {
            this.Width = Width;
        }

        /// <summary>
        /// Return Rovers.
        /// </summary>
        /// <returns>Rovers</returns>
        public List<Rover> GetRovers()
        {
            return this.Rovers;
        }

        /// <summary>
        /// Set Rovers.
        /// </summary>
        /// <param name="Rovers"></param>
        public void SetRovers(List<Rover> Rovers)
        {
            this.Rovers = Rovers;
        }
    }
}

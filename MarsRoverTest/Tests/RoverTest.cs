using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        
       [TestMethod]
        public void MoveNorthTest()
        {
            Rover myRover = new Rover();
            RoverService roverService = new RoverService();
            myRover.X = 1;
            myRover.Y = 2;
            myRover.Direction = Direction.North;
            var response = roverService.MoveNorth(myRover);
            Assert.AreEqual(myRover.Y, 3);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IsSuccess);
            Assert.IsNotNull(response.Message);
            Assert.IsTrue(response.IsSuccess, response.Message);
            if (!response.IsSuccess && !string.IsNullOrEmpty(response.Message))
            {
                Assert.Inconclusive(string.Format("Service success is false. Error Message{0}", response.Message), response.Message);
            }
        }

        [TestMethod]
        public void MoveEastTest()
        {
            Rover myRover = new Rover();
            RoverService roverService = new RoverService();
            myRover.X = 1;
            myRover.Y = 2;
            myRover.Direction = Direction.North;
            var response = roverService.MoveEast(myRover);
            Assert.AreEqual(myRover.X, 2);

            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IsSuccess);
            Assert.IsNotNull(response.Message);
            Assert.IsTrue(response.IsSuccess, response.Message);
            if (!response.IsSuccess && !string.IsNullOrEmpty(response.Message))
            {
                Assert.Inconclusive(string.Format("Service success is false. Error Message{0}", response.Message), response.Message);
            }
        }

        [TestMethod]
        public void MoveWestTest()
        {
            Rover myRover = new Rover();
            RoverService roverService = new RoverService();
            myRover.X = 1;
            myRover.Y = 2;
            myRover.Direction = Direction.North;
            var response = roverService.MoveWest(myRover);
            Assert.AreEqual(myRover.X, 0);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IsSuccess);
            Assert.IsNotNull(response.Message);
            Assert.IsTrue(response.IsSuccess, response.Message);
            if (!response.IsSuccess && !string.IsNullOrEmpty(response.Message))
            {
                Assert.Inconclusive(string.Format("Service success is false. Error Message{0}", response.Message), response.Message);
            }
        }

        [TestMethod]
        public void MoveSouthTest()
        {
            Rover myRover = new Rover();
            RoverService roverService = new RoverService();
            myRover.X = 1;
            myRover.Y = 2;
            myRover.Direction = Direction.North;
            var response = roverService.MoveSouth(myRover);
            Assert.AreEqual(myRover.Y, 1);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IsSuccess);
            Assert.IsNotNull(response.Message);
            Assert.IsTrue(response.IsSuccess, response.Message);
            if (!response.IsSuccess && !string.IsNullOrEmpty(response.Message))
            {
                Assert.Inconclusive(string.Format("Service success is false. Error Message{0}", response.Message), response.Message);
            }
        }

        [TestMethod]
        public void ChangeDirectionTest()
        {
            Rover myRover = new Rover();
            RoverService roverService = new RoverService();
            myRover.X = 1;
            myRover.Y = 2;
            myRover.Direction = Direction.North;
            var response = roverService.ChangeDirection(myRover,'L');
            Assert.AreEqual(myRover.Direction, Direction.West);
            Assert.IsNotNull(response);
            Assert.IsNotNull(response.IsSuccess);
            Assert.IsNotNull(response.Message);
            Assert.IsTrue(response.IsSuccess, response.Message);
            if (!response.IsSuccess && !string.IsNullOrEmpty(response.Message))
            {
                Assert.Inconclusive(string.Format("Service success is false. Error Message{0}", response.Message), response.Message);
            }
        }
    }
}

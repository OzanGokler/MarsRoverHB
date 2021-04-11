using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace MarsRoverTest
{
    [TestClass]
    public class GridTest
    {

        [TestMethod]
        public void SimulateGridTest()
        {
            GridService gridService = new GridService();
            List<Rover> myRoverList = new List<Rover>();
            myRoverList.Add(new Rover(0,1, 2, Direction.North, new List<char> { 'L', 'M', 'L', 'M', 'L', 'M', 'L', 'M', 'M' }));
            Grid myGrid = new Grid(5, 5, myRoverList);
            var response = gridService.SimulateGrid(myGrid);

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

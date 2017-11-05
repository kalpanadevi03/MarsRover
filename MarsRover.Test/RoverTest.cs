using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover.BusinessLogic;
using MarsRover.BusinessLogic.Rover;
using MarsRover.BusinessLogic.Rover.Impl;

namespace MarsRover.Test
{
    //To do - Implement Test methods using Autofac DI
    [TestClass]
    public class RoverTest
    {
        IRover _rover = new Rover();
       
        [TestMethod]
        public void SetPositionTest()
        {
            _rover.RoverPlateau = new Plateau();
            _rover.RoverPosition = new Position();
            _rover.RoverOrientation = new Orientations();
            string positionCoordinates = "1 2 N";
            _rover.SetPosition(positionCoordinates);
            Assert.IsNotNull(_rover.RoverPosition);
            Assert.IsNotNull(_rover.RoverOrientation);
            Assert.AreEqual(_rover.RoverPosition.X, 1);
            Assert.AreEqual(_rover.RoverPosition.Y, 2);
            Assert.AreEqual(_rover.RoverOrientation.ToString(), "N");
        }
        [TestMethod]
        public void ProcessTest()
        {
            _rover.RoverPosition = new Position();
            _rover.RoverPosition.X = 1;
            _rover.RoverPosition.Y = 2;
            string command = "LMLMLMLMM";
            _rover.Process(command);
            Assert.IsNotNull(_rover.RoverPosition);
            Assert.IsNotNull(_rover.RoverOrientation);
            Assert.AreEqual(_rover.RoverPosition.X, 1);
            Assert.AreEqual(_rover.RoverPosition.Y, 3);
            Assert.AreEqual(_rover.RoverOrientation.ToString(), "N");
        }
    }
}

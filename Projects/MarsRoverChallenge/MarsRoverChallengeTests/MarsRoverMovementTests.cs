using System;
using MarsRover;
using Xunit;

namespace MarsRoverTests
{
    public class RoverMovementTest
    {
        [Fact]
        public void TurnLeft()
        {
            //Arrange
            Rover rover = new Rover("1 2 N"); //facing north and turning 90 degrees
            //Act                             //left means you are now facing West
            rover.TurnLeft();
            //Assert
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 N");

            rover.TurnRight();

            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void Forward()
        {
            Rover rover = new Rover("1 2 N");

            rover.Forward();

            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void MoveTo()
        {
            Rover rover = new Rover("3 3 E");

            rover.MoveTo("MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}

using Rocket_Landing;
using System;
using Xunit;

namespace RoketLanding.Test
{
    public class CoordinateTest
    {
        [Theory]
        [InlineData(-1, 5, "xCoordinate should be greater than zero")]
        [InlineData(3, 0, "yCoordinate should be greater than zero")]
        public void Should_ThrowanExceptionWhen_TheProvidedCoordinateIsInvalid(int xCoordinate, int yCoordinate, string message)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Coordinate(xCoordinate, yCoordinate)).Message.Equals(message);
        }
    }
}
using Rocket_Landing;
using System;
using Xunit;

namespace RoketLanding.Test
{
    public class RocketPositionTest
    {
        [Fact]      
        public void Should_ThrowanException_WhenTheProvidedRocketPositionIsNull()
        {
            //Arrange
            string message = "position cannot be null";
            //Assert
            Assert.Throws<ArgumentNullException>(() => new RocketPosition(null)).Message.Equals(message);
        }
    }
}
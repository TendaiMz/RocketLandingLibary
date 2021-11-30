using Rocket_Landing;
using System;
using Xunit;

namespace RoketLanding.Test
{
    public class SettingsTest
    {
        [Fact]
        public void ShouldSetPlatformSize()
        {
            int platformSize = 15;
            //Act
            Settings.SetPlatformSize(platformSize);

            //Assert
            Assert.Equal(15,platformSize);
        }

        [Theory]
        [InlineData(-1 ,"-1 is not a valid platform size.The size should be between 1 and 100")]
        [InlineData(101, "101 is not a valid platform size.The size should be between 1 and 100")]
        public void Should_ThrowAnException_WhenTheProvidedSizeIsInvalid(int platformSize, string message)
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => Settings.SetPlatformSize(platformSize)).Message.Equals(message);
        }
    }
}
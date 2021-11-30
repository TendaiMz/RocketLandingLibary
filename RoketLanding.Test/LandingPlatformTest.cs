using Rocket_Landing;
using Xunit;

namespace RoketLanding.Test
{
    public class LandingPlatformTest
    {


        [Theory]
        [InlineData(3, 4, "Out Of Platform")]
        [InlineData(27, 17, "Out Of Platform")]

        public void ShouldReply_OutOfPlatform_WhenLandingPositionIsNotInsideTheLandingPlatform(int xCoordinate, int yCoordinate, string expectedResult)
        {
            //Arrange
            Coordinate rocketCoordinates = new Coordinate(xCoordinate, yCoordinate);
            LandingPlatform position = new LandingPlatform();

            //Act
            var result = position.CheckLandingPosition(rocketCoordinates);


            //Assert
            Assert.Equal(expectedResult, result);

        }

        [Theory]
        [InlineData(5, 5, "Ok For Landing")]
        [InlineData(8, 9, "Ok For Landing")]
        public void ShouldReply_OKForLanding_WhenLandingPositionIsNotOccupied(int xCoordinate, int yCoordinate, string expectedResult)
        {
            //Arrange
            Coordinate rocketCoordinates = new Coordinate(xCoordinate, yCoordinate);
           
            LandingPlatform position = new LandingPlatform();

            //Act
            var result = position.CheckLandingPosition(rocketCoordinates);
            

            //Assert
            Assert.Equal(expectedResult, result);          
        }

        [Theory]
        [InlineData(6, 6, "Clash")]
        [InlineData(7, 8, "Clash")]
        public void ShouldReply_Clash_WhenLandingPositionIsOccupied(int xCoordinate, int yCoordinate, string expectedResult)
        {
            //Arrange
            Coordinate firstrocketCoordinates = new Coordinate(xCoordinate, yCoordinate);
            Coordinate secondrocketCoordinates = new Coordinate(xCoordinate, yCoordinate);
            
            LandingPlatform position = new LandingPlatform();

            //Act         
            position.CheckLandingPosition(firstrocketCoordinates);
            var result = position.CheckLandingPosition(secondrocketCoordinates);


            //Assert
            Assert.Equal(expectedResult, result);
           
        }


    }
}
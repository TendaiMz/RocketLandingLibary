namespace Rocket_Landing
{
    public class LandingPlatform
    {
        private RocketPosition occupiedPosition;
        private int rocketSeperationSize = 1;
       
        public string CheckLandingPosition(Coordinate landingCoordinates)
        {
            if (IsCoordinateOutsideLandingPlatform(landingCoordinates))
            {
                return ResponseMessage.OutOfPlatform;
            }

            if (occupiedPosition != null)
            {
                if (IsCoordinateInsideLastCheckedPosition(landingCoordinates))
                {
                    return ResponseMessage.Clash;
                }

                if (IsCoordinateInsideLastCheckedPositionBoundaries(landingCoordinates))
                {
                    return ResponseMessage.Clash;
                }
            }
            occupiedPosition = new RocketPosition(landingCoordinates);
            return ResponseMessage.OkForLanding;
        }

        private bool IsCoordinateInsideLastCheckedPosition(Coordinate request)
        {
            return (occupiedPosition.TopLeft.XCoordinate == request.XCoordinate || occupiedPosition.TopRight.XCoordinate + 1 == request.XCoordinate)
               || (occupiedPosition.TopLeft.YCoordinate == request.YCoordinate || occupiedPosition.TopLeft.YCoordinate + 1 == request.YCoordinate);
        }

        private bool IsCoordinateInsideLastCheckedPositionBoundaries(Coordinate request)
        {
            return (occupiedPosition.TopLeft.XCoordinate - rocketSeperationSize == request.XCoordinate || occupiedPosition.TopRight.XCoordinate + rocketSeperationSize == request.XCoordinate
                      || occupiedPosition.TopLeft.YCoordinate - rocketSeperationSize == request.YCoordinate || occupiedPosition.BottomLeft.YCoordinate + rocketSeperationSize == request.YCoordinate);
        }

        private bool IsCoordinateOutsideLandingPlatform(Coordinate request)
        {
            return (Settings.PlatformSize + Settings.startingXcoordinate < request.XCoordinate || Settings.PlatformSize + Settings.startingYcoordinate < request.YCoordinate
                     || Settings.PlatformStartingPosition.XCoordinate > request.XCoordinate || Settings.PlatformStartingPosition.YCoordinate > request.YCoordinate);
        }
    }
}
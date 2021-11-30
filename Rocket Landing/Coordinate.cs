using System;

namespace Rocket_Landing
{
    public class Coordinate
    {
        public readonly int XCoordinate;
        public readonly int YCoordinate;

        public Coordinate(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate <= 0)
            {
               throw new ArgumentOutOfRangeException($"{nameof(xCoordinate)} should be greater than zero");
            }
            if (yCoordinate <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(xCoordinate)} should be greater than zero");
            }
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }
    }
}
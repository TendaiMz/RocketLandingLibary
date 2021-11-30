using System;

namespace Rocket_Landing
{
    public class RocketPosition
    {
        internal readonly Coordinate TopLeft;
        internal readonly Coordinate BottomLeft;
        internal readonly Coordinate TopRight;
        internal readonly Coordinate BottomRight;

        public RocketPosition(Coordinate position)
        {
            if (position == null)
            {
                throw new ArgumentNullException($"{nameof(position)} cannot be null");
            }

            TopLeft = new Coordinate(position.XCoordinate, position.YCoordinate);
            TopRight = new Coordinate(position.XCoordinate + 1, position.YCoordinate);
            BottomLeft = new Coordinate(position.XCoordinate, position.YCoordinate + 1);
            BottomRight = new Coordinate(position.XCoordinate + 1, position.YCoordinate + 1);
        }
    }
}
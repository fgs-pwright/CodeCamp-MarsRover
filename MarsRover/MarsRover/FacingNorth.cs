﻿namespace MarsRover
{
    public class FacingNorth : IOrientation
    {
        public Position Translate(Position position)
        {
            var nextPosition = position.Clone();
            nextPosition.Coordinates[1]++;
            return nextPosition;
        }

        public void Rotate(Rover contextRover, bool isTurningCounterclockwise)
        {
            if (isTurningCounterclockwise)
            {
                contextRover.SetOrientation(new FacingWest());
            }
            else
            {
                contextRover.SetOrientation(new FacingEast());
            }
        }
    }
}
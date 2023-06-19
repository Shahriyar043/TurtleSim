namespace TurtleSim.App
{
    public class Turtle
    {
        public Coordinate CurrentPosition { get; set; }
        public Directions CurrentDirection { get; set; }

        public Turtle(Coordinate position, Directions direction)
        {
            CurrentPosition = position;
            CurrentDirection = direction;
        }

        public void Advance()
        {
            switch (CurrentDirection)
            {
                case Directions.North:
                    CurrentPosition.Y += 1;
                    break;
                case Directions.East:
                    CurrentPosition.X += 1;
                    break;
                case Directions.South:
                    CurrentPosition.Y -= 1;
                    break;
                case Directions.West:
                    CurrentPosition.X -= 1;
                    break;
            }
        }

        public void TurnRight()
        {
            CurrentDirection = (Directions)(((int)CurrentDirection + 1) % 4);
        }

        public void TurnLeft()
        {
            CurrentDirection = (Directions)(((int)CurrentDirection + 3) % 4);
        }
    }
}

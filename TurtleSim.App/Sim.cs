namespace TurtleSim.App
{
    public class Sim
    {
        private int _boardSize;
        private Turtle _turtle;

        public Sim(int boardSize)
        {
            _boardSize = boardSize;
        }

        public bool PlaceTurtle(Coordinate coordinate, Directions direction)
        {
            if (coordinate.X < 0 || coordinate.Y < 0 || coordinate.X >= _boardSize || coordinate.Y >= _boardSize)
                return false;

            _turtle = new Turtle(coordinate, direction);
            return true;
        }

        public void MoveTurtle()
        {
            if (_turtle != null)
            {
                Turtle hypotheticalTurtle = new Turtle(new Coordinate(_turtle.CurrentPosition.X, _turtle.CurrentPosition.Y), _turtle.CurrentDirection);
                hypotheticalTurtle.Advance();

                if (hypotheticalTurtle.CurrentPosition.X >= 0 && hypotheticalTurtle.CurrentPosition.Y >= 0 && hypotheticalTurtle.CurrentPosition.X < _boardSize && hypotheticalTurtle.CurrentPosition.Y < _boardSize)
                {
                    _turtle.Advance();
                }
            }
        }

        public void TurnTurtleRight()
        {
            _turtle?.TurnRight();
        }

        public void TurnTurtleLeft()
        {
            _turtle?.TurnLeft();
        }

        public string Report()
        {
            return _turtle != null
                ? $"{_turtle.CurrentPosition.X},{_turtle.CurrentPosition.Y},{_turtle.CurrentDirection.ToString().ToUpper()}"
                : "Turtle not placed";
        }
    }
}

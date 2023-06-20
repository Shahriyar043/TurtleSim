using TurtleSim.App;
using Xunit;

namespace TurtleSim.Tests
{
    public class TurtleTests
    {
        [Fact]
        public void TestTurtleAdvanceNorth()
        {
            var turtle = new Turtle(new Coordinate(0, 0), Directions.North);
            turtle.Advance();
            Assert.Equal(1, turtle.CurrentPosition.Y);
        }

        [Fact]
        public void TestTurtleAdvanceSouth()
        {
            var turtle = new Turtle(new Coordinate(0, 1), Directions.South);
            turtle.Advance();
            Assert.Equal(0, turtle.CurrentPosition.Y);
        }

        [Fact]
        public void TestTurtleTurnRight()
        {
            var turtle = new Turtle(new Coordinate(0, 0), Directions.North);
            turtle.TurnRight();
            Assert.Equal(Directions.East, turtle.CurrentDirection);
        }
    }
}

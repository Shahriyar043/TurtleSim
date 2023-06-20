using TurtleSim.App;
using Xunit;

namespace TurtleSim.Tests
{
    public class SimTests
    {
        [Fact]
        public void TestSimPlaceTurtle()
        {
            var sim = new Sim(5);
            bool result = sim.PlaceTurtle(new Coordinate(0, 0), Directions.North);
            Assert.True(result);
            Assert.Equal("0,0,NORTH", sim.Report());
        }

        [Fact]
        public void TestSimMoveTurtle()
        {
            var sim = new Sim(5);
            sim.PlaceTurtle(new Coordinate(0, 0), Directions.North);
            sim.MoveTurtle();
            Assert.Equal("0,1,NORTH", sim.Report());
        }

        [Fact]
        public void TestSimTurnTurtleRight()
        {
            var sim = new Sim(5);
            sim.PlaceTurtle(new Coordinate(0, 0), Directions.North);
            sim.TurnTurtleRight();
            Assert.Equal("0,0,EAST", sim.Report());
        }
    }
}

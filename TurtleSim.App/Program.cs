using System;

namespace TurtleSim.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sim sim = new Sim(5);

            while (true)
            {
                string command = Console.ReadLine();

                if (string.IsNullOrEmpty(command))
                    break;

                string[] parts = command.Split(' ');                

                switch (parts[0].ToUpper())
                {
                    case "PLACE":
                        Place(command,sim);
                        string[] parameters = parts[1].Split(',');
                        sim.PlaceTurtle(new Coordinate(int.Parse(parameters[0]), int.Parse(parameters[1])), Enum.Parse<Directions>(parameters[2], ignoreCase: true));
                        break;
                    case "MOVE":
                        sim.MoveTurtle();
                        break;
                    case "LEFT":
                        sim.TurnTurtleLeft();
                        break;
                    case "RIGHT":
                        sim.TurnTurtleRight();
                        break;
                    case "REPORT":
                        Console.WriteLine(sim.Report());
                        break;
                    case "EXIT":
                        goto Exit;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }

                Exit:
                return;
            }

        }

        static void Place(string command, Sim sim)
        {
            string[] split = command.Split(',');

            if (split.Length < 3)
            {
                Console.WriteLine("Invalid PLACE command. Format should be PLACE X,Y,F");
                return;
            }

            int x = int.Parse(split[0]);
            int y = int.Parse(split[1]);
            Directions f = Enum.Parse<Directions>(split[2]);

            if (!sim.PlaceTurtle(new Coordinate(x, y), f))
            {
                Console.WriteLine($"Cannot place the turtle at ({x},{y}). Out of bounds.");
            }
        }
    }
}

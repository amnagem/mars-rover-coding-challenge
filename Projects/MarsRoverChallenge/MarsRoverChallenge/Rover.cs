using System;
namespace MarsRover
{
    public class Rover
    {
        public int x;
        public int y;
        public string direction;

        public Rover(string location)
        {
            Int32.TryParse(location.Split(" ")[0], out x);
            Int32.TryParse(location.Split(" ")[1], out y);
            direction = location.Split(" ")[2];

        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                    direction = "W";
                    break;

                case "E":
                    direction = "N";
                    break;

                case "S":
                    direction = "E";
                    break;

                case "W":
                    direction = "S";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;

                case "E":
                    direction = "S";
                    break;

                case "S":
                    direction = "W";
                    break;

                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public void MoveTo(string roverInstructions)
        {
            char[] message = roverInstructions.ToCharArray();

            for (int i = 0; i < message.Length; i++)
            {
                switch (message[i])
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Forward();
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
        }

        public void Forward()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;

                case "E":
                    x += 1;
                    break;

                case "S":
                    y -= 1;
                    break;

                case "W":
                    x -= 1;
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}



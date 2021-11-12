using System;
using System.Linq;

namespace seaBattle
{
    public class Viewer
    {
        private PlayGround _userPlayGround;
        private PlayGround _computerPlayGround;


        public Viewer(PlayGround userPlayGround, PlayGround computerPlayGround)
        {
            _userPlayGround = userPlayGround;
            _computerPlayGround = computerPlayGround;
        }


        public void PrintGame()
        {
            Console.Write("-----------------Your playground-----------------\n");
            PrintPlayGround(_userPlayGround, true);
            Console.Write("------------------PC playground------------------\n");
            PrintPlayGround(_computerPlayGround, false);
        }


        private void PrintPlayGround(PlayGround playGround, bool seeShips)
        {
            var numberOfCell = 0;
            foreach (var cell in playGround.Cells)
            {
                if (cell.IsShooted)
                {
                    if (cell.IsOccupied)
                    {
                        var ship = playGround.Ships.Single(s =>
                            s.Cells.Any(c => c.X.Equals(cell.X) && c.Y.Equals(cell.Y)));
                        Console.Write(ship.IsKilled() ? " [У] " : " [P] ");
                    }
                    else
                    {
                        Console.Write(" [O] ");
                    }
                }
                else
                {
                    if (cell.IsOccupied)
                    {
                        Console.Write(seeShips ? " [X] " : " [ ] ");
                    }
                    else
                    {
                        Console.Write(" [ ] ");
                    }
                }

                numberOfCell++;
                if (numberOfCell == 10)
                {
                    numberOfCell = 0;
                    Console.WriteLine("");
                }
            }

            Console.WriteLine("");
        }
    }
}

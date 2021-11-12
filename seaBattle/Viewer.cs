using System;

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
                if (cell.IsOccupied)
                {
                    Console.Write(seeShips ? " [X] " : " [ ] ");
                }
                else if (cell.IsShooted)
                {
                    Console.Write(" [0] ");
                }
                else
                {
                    Console.Write(" [ ] ");
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

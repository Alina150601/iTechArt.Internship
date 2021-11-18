using System;
using System.Linq;

namespace seaBattle
{
    public class Game
    {
        private PlayGround _userPlayGround;
        private PlayGround _computerPlayGround;
        private Viewer _viewer;

        public Game()
        {
            _computerPlayGround = new PlayGround();
            _userPlayGround = new PlayGround();
            _viewer = new Viewer(_userPlayGround, _computerPlayGround);
        }


        public void Start()
        {
            while (true)
            {
                _viewer.PrintGame();
                Console.WriteLine("Enter X: ");
                var stringInputX = Console.ReadLine();
                var success = int.TryParse(stringInputX, out var inputX);
                if (success && inputX <= 10 && inputX >= 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Enter Y: ");
                        var stringInputY = Console.ReadLine();
                        success = int.TryParse(stringInputY, out var inputY);
                        if (success && inputY <= 10 && inputY >= 1)
                        {
                            _computerPlayGround.Shoot(inputX, inputY);
                            var currentCell = _computerPlayGround.TakeCell(inputX, inputY);
                            if (!currentCell.IsOccupied)
                            {
                                ComputerShoot();
                            }

                            break;
                        }

                        Console.WriteLine("Enter number plz (1-10)");
                    }
                }
                else
                {
                    Console.WriteLine("Enter number plz (1-10)");
                }
            }
        }

        private void ComputerShoot()
        {
            var freeCells = _userPlayGround.Cells.Where(x => !x.IsShooted).ToList();
            var rnd = new Random();
            var chosenCell = freeCells[rnd.Next(0, freeCells.Count)];
            _userPlayGround.Shoot(chosenCell);
        }
    }
}

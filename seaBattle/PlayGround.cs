using System;
using System.Collections.Generic;
using System.Linq;

namespace seaBattle
{
    public class PlayGround
    {
        public List<Cell> Cells { get; set; }

        public List<Ship> Ships { get; set; }


        public PlayGround()
        {
            Cells = new List<Cell>();
            for (var x = 1; x <= 10; x++)
            {
                for (var y = 1; y <= 10; y++)
                {
                    var cell = new Cell(x, y);
                    Cells.Add(cell);
                }
            }

            Ships = new List<Ship>
            {
                new Ship(1),
                new Ship(1),
                new Ship(1),
                new Ship(1),
                new Ship(2),
                new Ship(2),
                new Ship(2),
                new Ship(3),
                new Ship(3),
                new Ship(4)
            };
        }


        public void FillWithShips()
        {
            foreach (var ship in Ships)
            {
                LocateShip(ship);
            }
        }

        private void LocateShip(Ship ship)
        {
            var rnd = new Random();
            while (true)
            {
                var coordinateX = rnd.Next(1, 11);
                var coordinateY = rnd.Next(1, 11);
                var chosenVectorOfShip = rnd.Next(1, 5);
                var currentCell = Cells.Single(oneCell => oneCell.X == coordinateX && oneCell.Y == coordinateY);

                switch (chosenVectorOfShip)
                {
                    case 1: //up
                        if (currentCell.Y - 1 >= 1 && currentCell.Y - 2 >= 1 && currentCell.Y - 3 >= 1)
                        {
                            OccupyCell(currentCell, ship);
                            for (var i = 1; i < ship.Length; i++)
                            {
                                var nextCell = Cells.Single(cell =>
                                    cell.Y == coordinateY - i && cell.X == coordinateX);
                                OccupyCell(nextCell, ship);
                            }

                            return;
                        }

                        break;
                    case 2: //down
                        if (currentCell.Y + 1 <= 10 && currentCell.Y + 2 <= 10 && currentCell.Y + 3 <= 10)
                        {
                            OccupyCell(currentCell, ship);
                            for (var i = 1; i < ship.Length; i++)
                            {
                                var nextCell = Cells.Single(cell =>
                                    cell.Y == coordinateY + i && cell.X == coordinateX);
                                OccupyCell(nextCell, ship);
                            }

                            return;
                        }

                        break;
                    case 3: //right
                        if (currentCell.X + 1 <= 10 && currentCell.X + 2 <= 10 && currentCell.X + 3 <= 10)
                        {
                            OccupyCell(currentCell, ship);
                            for (var i = 1; i < ship.Length; i++)
                            {
                                var nextCell = Cells.Single(cell =>
                                    cell.X == coordinateX + i && cell.Y == coordinateY);
                                OccupyCell(nextCell, ship);
                            }

                            return;
                        }


                        break;
                    case 4: //left
                        if (currentCell.X - 1 >= 1 && currentCell.X - 2 >= 1 && currentCell.X - 3 >= 1)
                        {
                            OccupyCell(currentCell, ship);
                            for (var i = 1; i < ship.Length; i++)
                            {
                                var nextCell = Cells.Single(cell =>
                                    cell.X == coordinateX - i && cell.Y == coordinateY);
                                OccupyCell(nextCell, ship);
                            }
                            return;
                        }

                        break;
                }
            }
        }

        private void OccupyCell(Cell cell, Ship ship)
        {
            cell.IsOccupied = true;
            cell.IsAllowed = false;
            ship.Cells.Add(cell);

            var nearCells = Cells.Where(current =>
                current.X == cell.X + 1 && current.Y == cell.Y
                || current.X == cell.X + 1 && current.Y == cell.Y + 1
                || current.X == cell.X + 1 && current.Y == cell.Y - 1
                || current.X == cell.X && current.Y == cell.Y + 1
                || current.X == cell.X && current.Y == cell.Y - 1
                || current.X == cell.X - 1 && current.Y == cell.Y
                || current.X == cell.X - 1 && current.Y == cell.Y + 1
                || current.X == cell.X - 1 && current.Y == cell.Y - 1);
            foreach (var c in nearCells)
            {
                c.IsAllowed = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace seaBattle
{
    public class PlayGround
    {
        public List<Cell> Cells { get; set; }

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
        }

        public void LocateShip(Sheep ship)
        {
            var rnd = new Random();
            var coordinateX = rnd.Next(1, 11);
            var coordinateY = rnd.Next(1, 11);
            var chosenVectorOfShip = rnd.Next(1, 5);
            var currentCell = Cells.Single(oneCell => oneCell.X == coordinateX && oneCell.Y == coordinateY);

            switch (chosenVectorOfShip)
            {
                case 1: //up
                    if (currentCell.Y - 1 >= 1 && currentCell.Y - 2 >= 1 && currentCell.Y - 3 >= 1)
                    {
                        currentCell.IsOccupied = true;
                        for (var i = 1; i < ship.Length; i++)
                        {
                            var nextCell = Cells.Single(cell => cell.Y == coordinateY - i && cell.X == coordinateX);
                            nextCell.IsOccupied = true;
                        }
                    }
                    else
                    {
                        goto case 2;
                    }

                    break;
                case 2: //down
                    if (currentCell.Y + 1 <= 10 && currentCell.Y + 2 <= 10 && currentCell.Y + 3 <= 10)
                    {
                        currentCell.IsOccupied = true;
                        for (var i = 1; i < ship.Length; i++)
                        {
                            var nextCell = Cells.Single(cell => cell.Y == coordinateY + i && cell.X == coordinateX);
                            nextCell.IsOccupied = true;
                        }
                    }
                    else
                    {
                        goto case 3;
                    }

                    break;
                case 3: //right
                    if (currentCell.X + 1 <= 10 && currentCell.X + 2 <= 10 && currentCell.X + 3 <= 10)
                    {
                        currentCell.IsOccupied = true;
                        for (var i = 1; i < ship.Length; i++)
                        {
                            var nextCell = Cells.Single(cell => cell.X == coordinateX + i && cell.Y == coordinateY);
                            nextCell.IsOccupied = true;
                        }
                    }
                    else
                    {
                        goto case 4;
                    }

                    break;
                case 4: //left
                    if (currentCell.X - 1 >= 1 && currentCell.X - 2 >= 1 && currentCell.X - 3 >= 1)
                    {
                        currentCell.IsOccupied = true;
                        for (var i = 1; i < ship.Length; i++)
                        {
                            var nextCell = Cells.Single(cell => cell.X == coordinateX - i && cell.Y == coordinateY);
                            nextCell.IsOccupied = true;
                        }
                    }
                    else
                    {
                        goto case 1;
                    }

                    break;
            }
        }

        public void OccupyCell(Cell cell)
        {
            cell.IsOccupied = true;
            cell.IsAllowed = false;
            var nearCells = new List<Cell>();
            nearCells = Cells.Where(current => current.X == current.X + 1 ).ToList();
        }
    }
}

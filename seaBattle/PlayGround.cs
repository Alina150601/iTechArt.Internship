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
                new(4),
                new(3),
                new(3),
                new(2),
                new(2),
                new(2),
                new(1),
                new(1),
                new(1),
                new(1)
            };

            foreach (var ship in Ships)
            {
                LocateShip(ship);
            }
        }


        public Cell TakeCell(int x, int y)
        {
            var single = Cells.SingleOrDefault(oneCell => oneCell.X == x && oneCell.Y == y);
            return single; // returns NULL if nothing found (for example coordinates were wrong - <1 or >10)
        }


        private void LocateShip(Ship ship)
        {
            var rnd = new Random();
            while (true)
            {
                var coordinateX = rnd.Next(1, 11);
                var coordinateY = rnd.Next(1, 11);
                var chosenCell = TakeCell(coordinateX, coordinateY);
                if (!chosenCell.IsAllowed)
                {
                    continue;
                }

                var directions = Enum.GetValues(typeof(Direction));
                var chosenDirection = (Direction)directions.GetValue(rnd.Next(directions.Length));

                if (TryToLocateShip(ship, chosenCell, chosenDirection))
                {
                    return;
                }
            }
        }

        private bool TryToLocateShip(Ship ship, Cell cell, Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:

                    var allowedCellsCount = 0;
                    var cellToCheck = cell;
                    for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                    {
                        if (cellToCheck.IsAllowed)
                        {
                            cellToCheck = TakeCell(cell.X, cell.Y - cellIndex);
                            if (cellToCheck != null)
                            {
                                allowedCellsCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (allowedCellsCount == ship.Length)
                    {
                        OccupyCell(cell, ship);
                        for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                        {
                            var nextCell = TakeCell(cell.X, cell.Y - cellIndex);
                            OccupyCell(nextCell, ship);
                        }

                        return true;
                    }

                    break;
                case Direction.Down:
                    allowedCellsCount = 0;
                    cellToCheck = cell;
                    for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                    {
                        if (cellToCheck.IsAllowed)
                        {
                            cellToCheck = TakeCell(cell.X, cell.Y + cellIndex);
                            if (cellToCheck != null)
                            {
                                allowedCellsCount++;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (allowedCellsCount == ship.Length)
                    {
                        OccupyCell(cell, ship);
                        for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                        {
                            var nextCell = TakeCell(cell.X, cell.Y - cellIndex);
                            OccupyCell(nextCell, ship);
                        }

                        return true;
                    }

                    break;
                case Direction.Right:
                    allowedCellsCount = 0;
                    cellToCheck = cell;
                    for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                    {
                        if (cellToCheck.IsAllowed)
                        {
                            cellToCheck = TakeCell(cell.X + cellIndex, cell.Y);
                            if (cellToCheck != null)
                            {
                                allowedCellsCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (allowedCellsCount == ship.Length)
                    {
                        OccupyCell(cell, ship);
                        for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                        {
                            var nextCell = TakeCell(cell.X + cellIndex, cell.Y);
                            OccupyCell(nextCell, ship);
                        }

                        return true;
                    }

                    break;
                case Direction.Left:
                    allowedCellsCount = 0;
                    cellToCheck = cell;
                    for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                    {
                        if (cellToCheck.IsAllowed)
                        {
                            cellToCheck = TakeCell(cell.X - cellIndex, cell.Y);
                            if (cellToCheck != null)
                            {
                                allowedCellsCount++;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    if (allowedCellsCount == ship.Length)
                    {
                        OccupyCell(cell, ship);
                        for (var cellIndex = 0; cellIndex < ship.Length; cellIndex++)
                        {
                            var nextCell = TakeCell(cell.X - cellIndex, cell.Y);
                            OccupyCell(nextCell, ship);
                        }

                        return true;
                    }

                    break;
            }

            return false;
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

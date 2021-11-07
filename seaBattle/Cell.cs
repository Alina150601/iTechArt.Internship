using System.Collections.Generic;

namespace seaBattle
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsOccupied { get; set; }

        public bool IsAllowed { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

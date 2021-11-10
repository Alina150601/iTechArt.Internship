namespace seaBattle
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }
        public bool IsOccupied { get; set; }

        public bool IsAllowed { get; set; }

        public Cell(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}

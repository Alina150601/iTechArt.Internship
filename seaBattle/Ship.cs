using System;
using System.Collections.Generic;
using System.Linq;

namespace seaBattle
{
    public class Ship
    {
        public int Length { get; set; }

        public List<Cell> Cells { get; set; }


        public Ship(int length)
        {
            if (length <= 4 && length >= 1) Length = length;
            else throw new ArgumentException();
            Cells = new List<Cell>(length);
        }

        public bool IsKilled() => Cells.All(x => x.IsShooted);
    }
}

namespace seaBattle
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            PlayGround userPlayGround = new PlayGround();
            userPlayGround.FillWithShips();


            PlayGround computerPlayGround = new PlayGround();
            computerPlayGround.FillWithShips();

        }
    }
}
}

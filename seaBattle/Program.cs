namespace seaBattle
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            Sheep sheep = new Sheep(4);
            PlayGround playGround = new PlayGround();
            playGround.LocateShip(sheep);
        }
    }
}

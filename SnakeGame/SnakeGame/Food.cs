namespace SnakeGame
{
    public class Food
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public char Symbol { get; set; }

        private char[] foodSymbols = new char[] { '#', '@', '%', '*', '&' };

        public Food(int windowHeight, int windowWidth)
        {
            Random random = new Random();
            this.XCoordinate = random.Next(2, windowWidth);
            this.YCoordinate = random.Next(2, windowHeight);

            this.Symbol = foodSymbols[random.Next(0, foodSymbols.Length)];
        }
    }
}

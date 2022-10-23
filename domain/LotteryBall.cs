using static System.Random;
using static System.Math;


namespace domain.LotteryBall
{
    class LotteryBall
    {
        public LotteryBall()
        {
            number = getBallNumber();
            colour = getBallColour(number);
        }

        public int getBallNumber()
        {
            number = this.random.Next(1, 50);
            return number;
        }

        public string getBallColour(int Number)
        {
            decimal dividedNumber = Number / 10;
            decimal caseNumber = Math.Floor(dividedNumber);

            switch (caseNumber)
            {
                case 0:
                    colour = "red";
                    return colour;

                case 1:
                    colour = "blue";
                    return colour;

                case 2:
                    colour = "green";
                    return colour;

                case 3:
                    colour = "pink";
                    return colour;

                case 4:
                    colour = "yellow";
                    return colour;

                default:
                    throw new ArgumentException("An error has occured.");
            }
        }
    
        private readonly Random random = new Random();
        private int number;
        private string colour;
        public int Number
        {
            get { return number; }
        }
        public string Colour
        {
            get { return colour; }
        }
    }
}
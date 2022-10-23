using domain.LotteryBall;

namespace app.BallSelection
{
    class RandomSelection
    {   
        private List<LotteryBall> lotteryBalls;
        public List<LotteryBall> LotteryBalls
        {
            get { return lotteryBalls; }
        }
        public int NumberOfBalls { get; set; }
        public RandomSelection(int numberOfBalls)
        {
            NumberOfBalls = numberOfBalls;
            lotteryBalls = selectedBalls(NumberOfBalls);
        }

        public List<LotteryBall> selectedBalls(int numberOfBalls)
        {
            List<LotteryBall> lotteryBalls = new List<LotteryBall>();

            for (int i = 0; i < numberOfBalls; i++)
            {
                LotteryBall newBall = new LotteryBall();
                while (lotteryBalls.Any(ball => ball.Number == newBall.Number))
                {
                    Console.WriteLine($"{newBall.Number} is already in list");
                    newBall = new LotteryBall();
                }
                lotteryBalls.Add(newBall);
            }

            return lotteryBalls;
        }

        //Use this method to display the balls after being sorted, i.e. remove the for loop
        public void displaySelectedBalls()
        {
            Console.WriteLine("Your lottery numbers are:- \n");

            foreach (LotteryBall ball in lotteryBalls)
            {
                switch (ball.Colour)
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case "blue":
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        break;
                    case "pink":
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        break;
                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;
                }

                Console.Write($" {ball.Number} ");

                Console.ResetColor();
        }
    }
}
}

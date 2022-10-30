using app.BallSelection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of lottery balls to be displayed (below 50): - ");
        int ballsAsInt;
        string ballsAsString = Console.ReadLine();
        
        if ( int.TryParse(ballsAsString, out ballsAsInt) && ballsAsInt < 50 )
        {
            RandomSelection yourLotteryBalls = new RandomSelection(ballsAsInt);
            yourLotteryBalls.sortBalls();
            yourLotteryBalls.displaySelectedBalls();
        }
        else
        {
            Console.WriteLine($"{ballsAsString ?? "<null>"} is not a valid number.");
        }
    }
}
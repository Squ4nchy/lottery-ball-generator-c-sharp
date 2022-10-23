using System.Linq;
using Spectre.Console;
using domain.LotteryBall;
using app.BallSelection;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of lottery balls to be displayed: - ");
        RandomSelection test = new RandomSelection(int.Parse(Console.ReadLine()));
        
        test.displaySelectedBalls();

        /*
        for (int i = 0; i < test.NumberOfBalls; i++)
        {
            //Console.WriteLine(i);
            Console.WriteLine(test.LotteryBalls[i].Number);
        }*/
    }
}

/*int numberOfBalls = 5;

List<LotteryBall> lotteryBalls = new List<LotteryBall>();


foreach (var ball in lotteryBalls)
{
    Console.WriteLine($"{ball.Number} is {ball.Colour}");
}

for (int i = 0; i < numberOfBalls; i++)
{
    LotteryBall newBall = new LotteryBall();
    while (lotteryBalls.Any(ball => ball.Number == newBall.Number))
    {
        Console.WriteLine($"{newBall} is already in list");
        newBall = new LotteryBall();
    }
    lotteryBalls.Add(newBall);
}

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
}*/
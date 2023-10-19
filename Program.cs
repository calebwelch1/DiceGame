using System;

namespace Dice {

class Program
{
    static void Main(string[] args)
    {
        int playerRandomNum;
        int computerRandomNum;

        int playerTotal = 0;
        int computerTotal = 0;

        Random random = new Random();

        for (int i = 0; i < 5; i++) {
        Console.WriteLine("\nPress any key to roll the dice");

        Console.ReadKey();

        playerRandomNum = random.Next(1, 7);
        computerRandomNum = random.Next(1, 7);

        playerTotal += playerRandomNum;
        computerTotal += computerRandomNum;

        Console.WriteLine("You rolled:" + playerRandomNum);
        Console.WriteLine("Computer rolled:" + computerRandomNum);
        Console.WriteLine($"Your total is: {playerTotal}, computer total is: {computerTotal}");
        }

        Console.WriteLine($"You had: {playerTotal}, computer had: {computerTotal}");

        if (playerTotal > computerTotal) {
            Console.WriteLine("You won!");
        }
        else if (playerTotal < computerTotal) {
            Console.WriteLine("Computer won! Better luck next time!");
        }
        else {
            Console.WriteLine("Tie Game!");
        }
    }
}

}
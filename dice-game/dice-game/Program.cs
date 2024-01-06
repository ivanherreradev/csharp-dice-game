using DieSet;

Console.WriteLine("Welcome to the game of betting against the dice!");

int bet;
bool follow = true;

while (follow)
{
    Console.WriteLine("\nEnter your bet: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out bet))
    {
        if (bet > 0 && bet < 7)
        {
            Die die = new Die();

            int dieResult = die.Roll();

            if (dieResult == bet)
            {
                Console.WriteLine($"Congratulations!! you have won!\nYour bet: {bet}\nDie result: {dieResult}");
            }
            else
            {
                Console.WriteLine($"Sorry! the house has won!\nYour bet: {bet}\nDie Result: {dieResult}");
            }

            follow = false;
        }
        else
        {
            Console.WriteLine("Enter only numbers between 1 to 6! Please try again: ");
        }
    }
    else
    {
        Console.WriteLine("Invalid input! Please try again: ");
    }
}

Console.WriteLine("Thank you for playing!");


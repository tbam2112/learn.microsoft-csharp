internal class Program
{
    private static void Main(string[] args)
    {
        Random roll = new Random();

        int healthPlayer = 10;
        int healthMonster = 10;

        string[] players = { "Hero", "Monster" };
        string currentPlayer = "";
        string currentFoe = "";
        int currentFoeHealth = 0;

        while ((healthPlayer > 0) && (healthMonster > 0))
        {
            foreach (string player in players)
            {
                int diceOne = roll.Next(1, 11);
                int diceTwo = roll.Next(1, 11);

                int damage = (diceOne + diceTwo) / 2;

                if (player == players[0])
                {
                    currentPlayer = player;
                    currentFoe = players[1];
                    healthMonster -= damage;
                    currentFoeHealth = healthMonster;
                }
                else
                {
                    currentPlayer = player;
                    currentFoe = players[0];
                    healthPlayer -= damage;
                    currentFoeHealth = healthPlayer;
                }

                Console.WriteLine($"{currentFoe} was damaged and lost {damage} health and now has {currentFoeHealth} health");

                if (currentFoeHealth <= 0)
                {
                    Console.WriteLine($"{currentPlayer} wins!");
                    break;
                }
            }
        }

        // Format the program must output.
        /*
        Monster was damaged and lost 1 health and now has 9 health.
        Hero was damaged and lost 1 health and now has 9 health.
        Monster was damaged and lost 7 health and now has 2 health.
        Hero was damaged and lost 6 health and now has 3 health.
        Monster was damaged and lost 9 health and now has -7 health.
        Hero wins!
        */
    }
}


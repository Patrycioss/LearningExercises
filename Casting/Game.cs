using System.Diagnostics;
using Casting.Enemies;

namespace Casting;

public class Game
{
    // Reusable vars
    private static readonly Vector2 PLAYER_POSITION = new Vector2(100, 100);
    private readonly Random random = new Random();
    private readonly Player player = new Player(PLAYER_POSITION);

    public Game()
    {
        // Exercise 1:
        // Convert this double to a float.
        {
            // Setup
            double a = 5.0d;
            
            // Your answer:
            //float b = a;
            
        }
        
        // Exercise 2:
        // Convert this GameObject back to an Enemy and run the EvilThings() method on it.
        {
            // Setup
            GameObject gameObject = new Enemy(new Vector2(0,0), "Enemy");
            
            // Your answer:
        }
        
        // Exercise 3:
        // This GameObject has a 50% chance to be an Enemy or a Player. Log it if it's an Enemy.
        {
            // Setup
            int choice = random.Next(0, 2);
            GameObject gameObject = choice == 0 ? new Enemy(new Vector2(0, 0), "Enemy") : new Player(new Vector2(0, 0));

            // Your answer:
        }
        
        // Exercise 4: 
        // Find out which of the enemies have the same positions as the player without altering any of the above code.
        // Make sure that you're not finding the player itself. Print the enemy, if the debug line shows an enemy with a position of [100,100] it's correct.
        {
            // Setup
            List<GameObject> gameObjects = new List<GameObject>();
            int overlappingOne = random.Next(0, 10);
            int chosenPlayerIndex = random.Next(0, 10);

            for (int i = 0; i < 10; i++)
            {
                if (i == chosenPlayerIndex)
                {
                    gameObjects.Add(player);
                }

                if (i == overlappingOne)
                {
                    gameObjects.Add(new Enemy(player.GetPosition(), "Enemy"));
                }
                else
                {
                    gameObjects.Add(new Enemy(new Vector2(0, 0), "Enemy"));
                }
            }

            // Your answer:
                
        }


        // Exercise 5:
        // Find out how many of each type of Enemy are in the list of GameObjects. This will be random each time.
        {
            // Setup
            List<GameObject> gameObjects = new List<GameObject>();
            int chosenPlayerIndex = random.Next(0, 10);
            for (int i = 0; i < 10; i++)
            {
                if (i == chosenPlayerIndex)
                {
                    gameObjects.Add(player);
                }

                gameObjects.Add(MakeRandomEnemy(new Vector2(0, 0)));
            }

            int fastCount = 0;
            int flyingCount = 0;
            int slowCount = 0;

            void PrintResult()
            {
                Console.WriteLine($"FastCount: {fastCount}, FlyingCount: {flyingCount}, SlowCount: {slowCount}");
            }

            // Your answer:

        }
    }

    private Enemy MakeRandomEnemy(Vector2 pPosition)
    {
        int choice = random.Next(0, 3);

        switch (choice)
        {
            case 0:
                return new FastEnemy(pPosition);

            case 1:
                return new FlyingEnemy(pPosition);

            case 2:
                return new SlowEnemy(pPosition);

            default:
                throw new Exception("Invalid enemy number for random generation!");
        }
    }
}
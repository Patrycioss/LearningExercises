using Shared;

namespace Casting.Classes;

public class Enemy : GameObject
{
    private readonly string name;
    
    public Enemy(Vector2 pPosition, string pName) : base(pPosition)
    {
        name = pName;
    }

    public override string ToString()
    {
        return $"Enemy: '{name}' with position: {position}";
    }

    public void EvilThings()
    {
        Console.WriteLine($"Such evil things :(");
    }
}
using Shared;

namespace Casting.Classes;

public class Player : GameObject
{
    public Player(Vector2 pPosition) : base(pPosition)
    {
        
    }

    public override string ToString()
    {
        return $"Player";
    }
}
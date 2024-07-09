using Shared;

namespace Inheritance.Classes;

public class Monkey : Animal
{
    public override void Move()
    {
        position += new Vector2(2, 2);
    }
}
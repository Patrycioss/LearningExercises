using Shared;

namespace Inheritance.Classes;

public class Animal
{
    protected Vector2 position;
    
    public Vector2 GetPosition()
    {
        return position;
    }

    public virtual void Move()
    {
        position += new Vector2(1, 1);
    }
}
using Shared;

namespace Casting.Classes;

public class GameObject
{
    protected Vector2 position;

    private static int objectCounter;
    private readonly int id;

    public GameObject(Vector2 pPosition)
    {
        position = pPosition;
        id = objectCounter++;
    }

    public void SetPosition(Vector2 pPosition)
    {
        position = pPosition;
    }

    public Vector2 GetPosition()
    {
        return position;
    }

    public int GetID()
    {
        return id;
    }

    public override string ToString()
    {
        return $"GameObject with id: {id}";
    }
}
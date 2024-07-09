namespace Shared;

public struct Vector2
{
    private const float TOLERANCE = 0.001f;

    public float X;
    public float Y;

    public Vector2(float pX, float pY)
    {
        X = pX;
        Y = pY;
    }

    public override string ToString()
    {
        return $"[{X},{Y}]";
    }

    public static Vector2 operator +(Vector2 pFirst, Vector2 pSecond)
    {
        return new Vector2(pFirst.X + pSecond.X, pFirst.Y + pSecond.Y);
    }

    public static Vector2 operator -(Vector2 pFirst, Vector2 pSecond)
    {
        return new Vector2(pFirst.X - pSecond.X, pFirst.Y - pSecond.Y);
    }

    public static bool operator ==(Vector2 pFirst, Vector2 pSecond)
    {
        // Floats are wonky. Sometimes you think 3.0f is just 3, but actually it's then 3.0000000000001f, so it's not the same.
        // The tolerance solves that.
        return Math.Abs(pFirst.X - pSecond.X) < TOLERANCE && Math.Abs(pFirst.Y - pSecond.Y) < TOLERANCE;
    }

    public static bool operator !=(Vector2 pFirst, Vector2 pSecond)
    {
        return !(pFirst == pSecond);
    }
}
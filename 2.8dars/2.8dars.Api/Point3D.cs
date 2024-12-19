namespace _2._8dars.Api;

public struct Point3D
{
    public int X { get; } 
    public int Y { get; }

    public Point3D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double DistanceFromOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}

 public class Point
{
    public int X { get; }
    
    public int Y { get; }

    // Constructor to initialize the point with specific coordinates
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        // Check if the object is null or different than Point
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        // Compare the coordinates  
        var point = (Point)obj;
        return X == point.X && Y == point.Y;
    }

    // Generate a hash code for the Point Object
    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }
}
namespace Reflections;

public class Printer3D
{
    public Position3D CurrentPosition { get; set; }

    public Printer3D()
    {
        CurrentPosition = new Position3D(0, 0, 0);
    }

    public void MoveLeft(int distance)
    {
        CurrentPosition.X -= distance;

        Console.WriteLine($"Moved {distance} units to the left. New position: {CurrentPosition}");
    }

    public void MoveRight(int distance)
    {
        CurrentPosition.X += distance;
        Console.WriteLine($"Moved {distance} units to the right. New position: {CurrentPosition}");
    }

    public void MoveUp(int distance)
    {
        CurrentPosition.Z += distance;
        Console.WriteLine($"Moved {distance} units up. New position: {CurrentPosition}");
    }

    public void MoveDown(int distance)
    {
        CurrentPosition.Z -= distance;
        Console.WriteLine($"Moved {distance} units down. New position: {CurrentPosition}");
    }
}




public class Position3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Position3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public override string ToString() => $"X: {X}, Y: {Y}, Z: {Z}";

}
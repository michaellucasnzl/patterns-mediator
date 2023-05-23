namespace app;

public class Colour
{
    public byte Red { get; set; }
    public byte Green { get; set; }
    public byte Blue { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if (!obj.GetType().Equals(typeof(Colour))) throw new InvalidCastException();

        var colour = (Colour)obj;
        return (colour.Red == Red && colour.Green == Green && colour.Blue == Blue);
    }

    public override int GetHashCode()
    {
        return System.HashCode.Combine(Red, Green, Blue);
    }
}

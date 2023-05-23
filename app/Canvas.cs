namespace app;

public class Canvas
{
    public void OutputColour(Colour colour)
    {
        Console.WriteLine($"{colour.Red},{colour.Green},{colour.Blue}");
    }
}

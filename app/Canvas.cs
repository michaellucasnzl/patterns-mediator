namespace app;

public class Canvas
{
    public Colour BackgroundColour { get; set; } = new();
     
    public void SetBackgroundColour(Colour colour)
    {
        BackgroundColour = colour;
    }
}

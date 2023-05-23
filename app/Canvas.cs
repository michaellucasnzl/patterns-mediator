namespace app;

public class Canvas
{
    public Colour? BackgroundColour { get; set; }
     
    public void SetBackgroundColour(Colour colour)
    {
        BackgroundColour = colour;
    }
}

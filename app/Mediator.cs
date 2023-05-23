namespace app;

public class Mediator : IMediator
{
    public Canvas? Canvas { get; set; }
    public PaintMixer? PaintMixer { get; set; }

    public void Notify()
    {
        if (Canvas != null && PaintMixer != null)
        {
            Canvas.SetBackgroundColour(PaintMixer.GetMixedPaintColour());
        }
    }
}

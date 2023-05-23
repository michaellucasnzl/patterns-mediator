namespace app;

public class Mediator : IMediator
{
    public Canvas? _canvas { get; set; }
    public PaintMixer? _paintMixer { get; set; }

    public void Notify()
    {
        if (_canvas != null && _paintMixer != null)
        {
            _canvas.OutputColour(_paintMixer.GetMixedPaintColour());
        }
    }
}

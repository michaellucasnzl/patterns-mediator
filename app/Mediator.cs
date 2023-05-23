namespace app;

public class Mediator : IMediator
{
    private readonly Canvas _canvas;
    private readonly PaintMixer _paintMixer;

    public Mediator(Canvas canvas, PaintMixer paintMixer)
    {
        _canvas = canvas;
        _paintMixer = paintMixer;
    }

    public void Notify()
    {
        _canvas.OutputColour(_paintMixer.GetMixedPaintColour());
    }
}

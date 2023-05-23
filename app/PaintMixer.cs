namespace app;

public class PaintMixer
{
    private List<Paint> _paints = new();
    private Colour _mixedPaintColour = new();
    private readonly IMediator _mediator;

    public PaintMixer(IMediator mediator)
    {
        _mediator = mediator;
    }

    public void AddPaint(Paint paint)
    {
        _paints.Add(paint);
        _mediator.Notify();
    }

    public void MixPaint()
    {
        foreach (var paint in _paints)
        {
            switch (paint.PaintColour)
            {
                case PaintColours.Red: _mixedPaintColour.Red = GetUpdatedPaintColour(_mixedPaintColour.Red, paint.Value); break;
                case PaintColours.Green: _mixedPaintColour.Green = GetUpdatedPaintColour(_mixedPaintColour.Green, paint.Value); break;
                case PaintColours.Blue: _mixedPaintColour.Blue = GetUpdatedPaintColour(_mixedPaintColour.Blue, paint.Value); break;
                default: throw new NotImplementedException("Invalid colour");
            }
        }
    }

    public Colour GetMixedPaintColour()
    {
        return _mixedPaintColour;
    }

    private byte GetUpdatedPaintColour(byte existingValue, byte newValue)
    {
        int val = existingValue + newValue;
        if (val > 256)
        {
            val = 256;
        }
        return Convert.ToByte(val);
    }
}

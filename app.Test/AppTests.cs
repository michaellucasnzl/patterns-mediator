namespace app.Test;

public class AppTests
{
    private readonly PaintMixer _paintMixer;
    private readonly Canvas _canvas = new Canvas();
    private readonly List<CsvDataAttribute> _testData = new List<CsvDataAttribute>();

    public AppTests()
    {
        var mediator = new Mediator();
        _paintMixer = new PaintMixer(mediator);
        mediator.PaintMixer = _paintMixer;
        mediator.Canvas = _canvas;
    }

    [Theory]
    [CsvData("testdata.csv", true)]
    public void PaintMixingTests(string colour1, string colour1Value, string colour2,
        string colour2Value, string colour3, string colour3Value,
        string redResult, string greenResult, string blueResult)
    {
        _paintMixer.AddPaint(new Paint { PaintColour =Enum.Parse<PaintColours>(colour1), Value = byte.Parse(colour1Value) });
        _paintMixer.AddPaint(new Paint { PaintColour =Enum.Parse<PaintColours>(colour2), Value = byte.Parse(colour2Value) });
        _paintMixer.AddPaint(new Paint { PaintColour =Enum.Parse<PaintColours>(colour3), Value = byte.Parse(colour3Value) });
        _paintMixer.MixPaint();

        var mixedPaint = _paintMixer.GetMixedPaintColour();

        Assert.Equal(byte.Parse(redResult), mixedPaint.Red);
        Assert.Equal(byte.Parse(blueResult), mixedPaint.Blue);
        Assert.Equal(byte.Parse(greenResult), mixedPaint.Green);

        Assert.True(mixedPaint.Equals(_canvas.BackgroundColour));
    }   
}
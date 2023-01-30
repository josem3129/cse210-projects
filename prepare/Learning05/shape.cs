public abstract class Shapes
{
    protected string _color;

    private string _shapeName;

    public string GetsShapeName()
    {
        return _shapeName;
    }

    public void SetShapeName(String shapeName)
    {
        _shapeName = shapeName;
    }


    public string GetColor()
    {
        return _color;
    }

    public void SetColor (string color)
    {
        _color = color;
    }

    public abstract double GetArea();
    
}
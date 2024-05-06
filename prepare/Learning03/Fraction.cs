public class Fraction
{
    private int _top;
    private int _bottom;
    
    // Member names cannot be the same as their enclosing type
    public void Fraction1()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    public void Fraction1(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }
    public void Fraction1(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
    }

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    private string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }
    private double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
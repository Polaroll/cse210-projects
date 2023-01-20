public class Fraction 
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop() 
    {
        Console.WriteLine(_top);
    }
    public void SetTop()
    {
        Console.Write("Set a new top number: ");
        string stringTop = Console.ReadLine();
        int top = int.Parse(stringTop);
        _top = top;
    }
    public void GetBottom() 
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom()
    {
        Console.Write("Set a new top number: ");
        string stringBottom = Console.ReadLine();
        int bottom = int.Parse(stringBottom);
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom;
        return decimalValue;
    }
}
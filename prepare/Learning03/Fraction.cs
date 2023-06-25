public class Fraction
{
    // Attributes for the top and bottom numbers
    private int _top;
    private int _bottom;

    // Constructor to initialize the top and bottom numbers
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getter for the top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for the top number
    public void SetTop(int value)
    {
        _top = value;
    }

    // Getter for the bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for the bottom number
    public void SetBottom(int value)
    {
        _bottom = value;
    }

    // Method to return a string representation of the fractional view
    public string GetFractionalView()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return a double representation of the decimal view
    public double GetDecimalView()
    {
        return (double)_top / _bottom;
    }
}

using System;

// Ensure this class is defined in your project
public class Shape
{
    // This method might throw an exception to indicate that it needs to be overridden in a derived class
    public virtual double Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

public class Square : Shape
{
    private int size;

    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
            {
                 throw new ArgumentException("Height must be greater than or equal to 0");
            }
	    size = value;
        }
    }

    // Override the Area method to provide the specific implementation for a Square
    public override double Area()
    {
        return Size * Size;
    }

    public override string ToString()
    {
        return $"[Square] {Size} / {Size}";
    }
}

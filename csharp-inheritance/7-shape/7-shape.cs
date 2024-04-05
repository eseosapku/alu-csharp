public class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() method requires an implementation.");
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

using System;

public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0.");
            }
            width = value;
        }
    }

    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0.");
            }
            height = value;
        }
    }

    // Using 'new' keyword to hide the base class Area method
    public new int Area()
    {
        return Width * Height;
    }

    // Overriding the ToString() method from the base class
    public override string ToString()
    {
        return $"[Rectangle] {width} / {height}";
    }
}


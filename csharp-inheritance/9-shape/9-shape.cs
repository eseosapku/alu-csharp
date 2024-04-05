using System;

/// <summary>
/// Represents a rectangle.
/// </summary>
public class Rectangle : Shape
{
    protected int width;
    protected int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public virtual int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public virtual int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public override int Area()
    {
        return Width * Height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A string representation of the rectangle.</returns>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

/// <summary>
/// Represents a square.
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");
            size = value;
            Height = value;
            Width = value;
        }
    }

    /// <summary>
    /// Returns a string representation of the square.
    /// </summary>
    /// <returns>A string representation of the square.</returns>
    public override string ToString()
    {
        return $"[Square] {Size} / {Size}";
    }
}


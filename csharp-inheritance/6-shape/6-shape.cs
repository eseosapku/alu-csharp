using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle aRect = new Rectangle();
        aRect.Width = 10;
        aRect.Height = 2;

        if (typeof(Rectangle).IsSubclassOf(typeof(Shape)))
            Console.WriteLine("Rectangle is a subclass of Shape");
        else
            Console.WriteLine("Rectangle is NOT a subclass of Shape");

        Console.WriteLine("Width: {0}", aRect.Width);
        Console.WriteLine("Height: {0}", aRect.Height);

        // Call the Area() method explicitly
        Console.WriteLine("Area: {0}", aRect.Area());
    }
   }
using System;

/// <summary>
/// Represents a basic shape.
/// </summary>
public class Shape
{
    /// <summary>
    /// Calculates the area of the shape.
    /// </summary>
    /// <returns>The calculated area.</returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Represents a rectangle, a specific type of shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The calculated area.</returns>
    public override int Area()
    {
        return width * height;
    }
}

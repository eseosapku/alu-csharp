﻿using System;

public class Rectangle : Shape
{
    private int width;
    private int height;

    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    public override int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

public class Square : Rectangle
{
    private int size;

    public int Size
    {
        get => size;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = value;
            Height = value;
        }
    }
}
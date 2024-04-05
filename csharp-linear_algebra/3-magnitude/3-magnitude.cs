using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1; // Return -1 if the vector is not 2D or 3D
        }

        double sumOfSquares = 0;
        foreach (double component in vector)
        {
            sumOfSquares += component * component; // Sum the squares of each component
        }

        double magnitude = Math.Sqrt(sumOfSquares); // Calculate the square root of the sum
        return Math.Round(magnitude, 2); // Round the magnitude to the nearest hundredth
    }
}

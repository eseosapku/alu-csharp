using System;

public class MatrixTransformation
{
    // Applies a shear along the X-axis to a 2D matrix of points.
    public static double[,] ShearX(double[,] matrix, double shx)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = matrix[i, j];
                double y = i; // Assuming each row corresponds to a Y coordinate
                // Applying shear transformation
                result[i, j] = x + shx * y;
            }
        }

        return result;
    }

    // Applies a shear along the Y-axis to a 2D matrix of points.
    public static double[,] ShearY(double[,] matrix, double shy)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                double x = j; // Assuming each column corresponds to an X coordinate
                double y = matrix[i, j];
                // Applying shear transformation
                result[i, j] = shy * x + y;
            }
        }

        return result;
    }
}

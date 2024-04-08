using System;

public class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix.
    /// </summary>
    /// <param name="matrix">The matrix to calculate the determinant for.</param>
    /// <returns>The determinant of the matrix.</returns>
    public static double Determinant(double[,] matrix)
    {
        // Check if the matrix is 2D or 3D
        if (matrix.GetLength(0) != matrix.GetLength(1) || (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3))
        {
            return -1; // Return -1 for invalid matrix dimension
        }

        // Calculate determinant based on matrix dimension
        if (matrix.GetLength(0) == 2)
        {
            // For 2x2 matrix, ad-bc
            return (matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]);
        }
        else if (matrix.GetLength(0) == 3)
        {
            // For 3x3 matrix, a(ei − fh) − b(di − fg) + c(dh − eg)
            double a = matrix[0, 0];
            double b = matrix[0, 1];
            double c = matrix[0, 2];
            double d = matrix[1, 0];
            double e = matrix[1, 1];
            double f = matrix[1, 2];
            double g = matrix[2, 0];
            double h = matrix[2, 1];
            double i = matrix[2, 2];

            return (a * ((e * i) - (f * h))) - (b * ((d * i) - (f * g))) + (c * ((d * h) - (e * g)));
        }

        return -1; // Default case, should not reach here
    }
}

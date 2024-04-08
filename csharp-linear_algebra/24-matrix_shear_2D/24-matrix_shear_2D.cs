using System;

public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to shear.</param>
    /// <param name="direction">The direction of the shear (x or y).</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The resulting sheared matrix or a matrix containing -1 if the input is invalid.</returns>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Check if the matrix is square
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } }; // Return -1 for invalid matrix size
        }

        // Check if the direction is valid
        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } }; // Return -1 for invalid direction
        }

        // Shear the matrix based on the direction
        double[,] shearedMatrix = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (direction == 'x')
        {
            // Shear along the x-axis
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                shearedMatrix[i, 0] = Math.Round(matrix[i, 0] + (factor * matrix[i, 1]), 2);
                shearedMatrix[i, 1] = matrix[i, 1];
            }
        }
        else if (direction == 'y')
        {
            // Shear along the y-axis
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                shearedMatrix[0, j] = matrix[0, j];
                shearedMatrix[1, j] = Math.Round(matrix[1, j] + (factor * matrix[0, j]), 2);
            }
        }

        return shearedMatrix;
    }
}

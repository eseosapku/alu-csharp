using System;

/// <summary>
/// Provides methods for matrix operations.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix by a given shear factor and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to shear.</param>
    /// <param name="direction">The direction of the shear (either 'x' or 'y').</param>
    /// <param name="factor">The shear factor.</param>
    /// <returns>The resulting matrix after shearing.</returns>
    /// <remarks>
    /// The shear factor can be in either the X or Y direction but not both.
    /// If the matrix is of an invalid size or if given an axis that is not x or y, 
    /// the method returns a matrix containing -1.
    /// </remarks>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        // Get the dimensions of the matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if the matrix is square
        if (rows != cols)
        {
            // Return a matrix containing -1 if the matrix is not square
            return new double[,] { { -1 } };
        }

        // Check if the direction is valid
        if (direction != 'x' && direction != 'y')
        {
            // Return a matrix containing -1 if the direction is invalid
            return new double[,] { { -1 } };
        }

        // Create a new matrix to store the sheared values
        double[,] shearedMatrix = new double[rows, cols];

        // Perform shearing for each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (direction == 'x')
                {
                    // Shear along the x-axis
                    shearedMatrix[i, j] = matrix[i, j + (int)(i * factor)];
                }
                else
                {
                    // Shear along the y-axis
                    shearedMatrix[i, j] = matrix[i + (int)(j * factor), j];
                }
            }
        }

        return shearedMatrix;
    }
}


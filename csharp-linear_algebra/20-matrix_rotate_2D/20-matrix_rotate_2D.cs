using System;

public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix">The square 2D matrix to rotate.</param>
    /// <param name="angle">The angle in radians by which to rotate the matrix.</param>
    /// <returns>The resulting matrix after rotation.</returns>
    /// <remarks>
    /// "Rotation" in this context means to apply rotation to the value of each element in the matrix,
    /// not changing the positions of the values in the matrix.
    /// If the matrix is of an invalid size, the method returns a matrix containing -1.    
    /// </remarks>
    public static double[,] Rotate2D(double[,] matrix, double angle)
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

        // Create a new matrix to store the rotated values
        double[,] rotatedMatrix = new double[rows, cols];

        // Calculate the sin and cos of the angle
        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);

        // Find the center of the matrix
        double centerX = rows / 2.0;
        double centerY = cols / 2.0;

        // Perform rotation for each element in the matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Calculate the relative position from the center
                double relX = i - centerX;
                double relY = j - centerY;

                // Apply rotation formula
                double rotatedX = relX * cosTheta - relY * sinTheta + centerX;
                double rotatedY = relX * sinTheta + relY * cosTheta + centerY;

                // Round the result to the nearest integer
                int x = (int)Math.Round(rotatedX);
                int y = (int)Math.Round(rotatedY);

                // Check if the rotated coordinates are within the bounds of the original matrix
                if (x >= 0 && x < rows && y >= 0 && y < cols)
                {
                    rotatedMatrix[x, y] = matrix[i, j];
                }
            }
        }

        return rotatedMatrix;
    }
}

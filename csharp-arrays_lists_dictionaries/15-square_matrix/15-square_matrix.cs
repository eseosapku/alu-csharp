public class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        // Get the number of rows and columns in the original matrix
        int rows = myMatrix.GetLength(0);
        int cols = myMatrix.GetLength(1);

        // Create a new matrix to store the square values
        int[,] squaredMatrix = new int[rows, cols];

        // Compute the square value for each element in the original matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                squaredMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        return squaredMatrix;
    }
}

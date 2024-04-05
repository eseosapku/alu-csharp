Create a method that adds two matrices and returns the resulting matrix.

Class: MatrixMath
Prototype: public static double[,] Add(double[,] matrix1, double[,] matrix2)
The matrices can be either both 2D or both 3D
2D ex.: double[,] matrix = { { 1, 2 }, { 3, 4 } };
3D ex.: double[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
If any matrix is not a 2D or 3D matrix, or both matrices are not the same size, return a matrix containing -1

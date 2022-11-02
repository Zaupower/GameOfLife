namespace GameOfLife;

public class MatrixCalculator
{
    public int[,] GenMatrix(int lengthRow, int lengthCol)
    {
        Random rn = new Random();
        int[,] matrix = new int[lengthRow+4, lengthCol+4];
        int row, col;

        for (row = 2; row < matrix.GetLength(0)-2; row++)
        {
            for (col = 2; col < matrix.GetLength(1)-2; col++)
            {
                matrix[row, col] = rn.Next(0, 2);
            }
        }
        return matrix;
    }

    public void PrintMatrix(int[,] matrix)
    {
         for (int i = 2; i < matrix.GetLength(0)-1; i++)
        {
            Console.Write("{0} ", (matrix.GetLength(0) - 2) - i);
            for (int j = 2; j < matrix.GetLength(1)-2; j++)
            {
                if (i == matrix.GetLength(0) -2)
                {
                    Console.Write(" {0} ", j-1);
                }
                else
                {
                    Console.Write(matrix[i, j]==1?" + ": " - ");
                }
            }
            Console.WriteLine("");
        }


    }
}
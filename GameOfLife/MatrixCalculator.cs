namespace GameOfLife;

public class MatrixCalculator
{
    public int[,] GenMatrix(int lengthRow, int lengthCol)
    {
        Random rn = new Random();
        int[,] matrix = new int[lengthRow+2, lengthCol+2];
        int row, col;

        for (row = 0; row < lengthRow; row++)
        {
            for (col = 0; col < lengthCol; col++)
            {
                matrix[row, col] = rn.Next(0, 2);
            }
        }
        return matrix;
    }

    public void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            Console.Write("{0} ", (matrix.GetLength(0) - 2) - i);

            for (int j = 0; j < matrix.GetLength(1) - 2; j++)
            {
                if (i == matrix.GetLength(0) - 2)
                {
                    Console.Write("{0} ", j + 1);
                }
                else if (matrix[i, j] == 1)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("- ");
                }
            }

            Console.WriteLine("");
        }
    }
}
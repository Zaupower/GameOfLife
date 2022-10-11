namespace GameOfLife;

public class MatrixCalculator
{
    
    public int[,] GenMatrix(int size)
    {
        Random rn = new Random();
        int[,] matrix = new int[size,size];
        int row, col;
         
        for (row = 0; row < size; row++)
        {
            for (col = 0; col < size; col++)
            {
                matrix[row,col] = rn.Next(0, 2);
            }
        }
        return matrix;
    }

    public int[,]IdentityMAtrixModifier(int[,] originalMatrix)
    {
        int row, col;

        int[,] modifiedMatrix = new int[originalMatrix.GetLength(0), originalMatrix.GetLength(1)];
        
        try
        {
            modifiedMatrix = (int[,]) originalMatrix.Clone();
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error copying values");
            foreach (var element in modifiedMatrix)
            {
                Console.WriteLine(element);
            }
        }
        
        int lenght = modifiedMatrix.GetLength(0);
        for (row = 0; row < lenght; row++)
        {
            for (col = 0; col < lenght; col++)
            {
                // Checking if row is equal to column
                if (row > col)
                {
                    modifiedMatrix[row, col] = 0;
                }else if (row < col)
                {
                    modifiedMatrix[row, col] = 1; 
                }
            }
        }
        return modifiedMatrix;
    }
    public void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    
}
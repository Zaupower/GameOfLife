namespace GameOfLife;

public class MatrixCalculator
{
    
    public int[,] GenMatrix(int lengthRow, int lengthCol)
    {
        Random rn = new Random();
        int[,] matrix = new int[lengthRow,lengthCol];
        int row, col;
         
        for (row = 0; row < lengthRow; row++)
        {
            for (col = 0; col < lengthCol; col++)
            {
                matrix[row,col] = rn.Next(0, 2);
            }
        }
        return matrix;
    }

    public int[,]IdentityMAtrixModifier(int[,] originalMatrix)
    {
        int row, col;
        int lengthRow = 0;
        int lengthCol = 0;
        lengthRow = originalMatrix.GetLength(0);
        lengthCol = originalMatrix.GetLength(1);
        int[,] modifiedMatrix = new int[lengthRow, lengthCol];
        
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
        for (row = 0; row < lengthRow; row++)
        {
            for (col = 0; col < lengthCol; col++)
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
        for (int i = 0; i < matrix.GetLength(0)-1; i++)
        {
            Console.Write("{0} ", (matrix.GetLength(0)-2) - i );
            
            for (int j = 0; j < matrix.GetLength(1)-2; j++) {
                
                if (i == matrix.GetLength(0)-2)
                {
                    Console.Write("{0} ", j+1); 
                }else if (matrix[i,j] == 1)
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
namespace GameOfLife;

public class GameOfLife
{
    private int[,] fisrtGeneration;
    private int[,] nextGeneration;

    public void AddFirstGeneration(int[,] matrix)
    {
        this.fisrtGeneration = matrix;
    }
    
    public void GenNextGeneration(int[,] currentGenMatrix)
    {
        int row, col;

         nextGeneration = new int[currentGenMatrix.GetLength(0), currentGenMatrix.GetLength(1)];
        
        try
        {
            nextGeneration= (int[,]) currentGenMatrix.Clone();
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error copying values");
            foreach (var element in nextGeneration)
            {
                Console.WriteLine(element);
            }
        }
        
        int lenght = nextGeneration.GetLength(0);
        
        for (row = 1; row < lenght-1; row++)
        {
            for (col = 1; col < lenght-1; col++)
            {
                // Checking if row is equal to column
                if (row > col)
                {
                    nextGeneration[row, col] = 0;
                }else if (row < col)
                {
                    nextGeneration[row, col] = 1; 
                }
            }
        }

        this.nextGeneration = currentGenMatrix;
    }
}
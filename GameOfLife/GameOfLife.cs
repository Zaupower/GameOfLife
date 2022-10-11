
public class GameOfLifeHelper
{
    private int[,] nextGeneration;


    public int[,] GenNextGeneration(int[,] currentGenMatrix)
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
        int cellSum = 0;
        for (row = 1; row < lenght-1; row++)
        {
            for (col = 1; col < lenght-1; col++)
            {
                cellSum = getCellSum(currentGenMatrix, row,col);
                //If exactly three neighbors are alive and the current cell is dead revive it on the next gen
                if (currentGenMatrix[row,col] == 0 && cellSum == 3)
                {
                    nextGeneration[row, col] = 1;
                }else if (currentGenMatrix[row,col] == 1 && cellSum < 2 || cellSum > 3)
                {
                    nextGeneration[row, col] = 0; 
                }
            }
        }
        return nextGeneration;
    }

    private int getCellSum(int[,] currentGenMatrix, int row, int col)
    {
        int sum =0;
        sum += currentGenMatrix[row - 1, col - 1];
        sum += currentGenMatrix[row - 1, col ];
        sum += currentGenMatrix[row - 1, col + 1];
        sum += currentGenMatrix[row, col - 1];
        
        sum += currentGenMatrix[row, col + 1];
        sum += currentGenMatrix[row + 1, col - 1];
        sum += currentGenMatrix[row + 1, col];
        sum += currentGenMatrix[row + 1, col + 1];
        return sum;
    }

}
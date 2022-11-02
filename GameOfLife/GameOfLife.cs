
namespace GameOfLife;

public class GameOfLifeHelper
{
    private int[,] _nextGeneration;

    public int[,] GenNextGeneration(int[,] currentGenMatrix)
    {
        int row, col;
        int lenghtRow = 0;
        int lenghtCol = 0;

        lenghtRow =currentGenMatrix.GetLength(0);
        lenghtCol =currentGenMatrix.GetLength(1);
        _nextGeneration = new int[lenghtRow, lenghtCol];
        
        try
        {
            _nextGeneration= (int[,]) currentGenMatrix.Clone();
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Error copying values");
            foreach (var element in _nextGeneration)
            {
                Console.WriteLine(element);
            }
        }
        
        int cellSum = 0;
        for (row = 2; row < lenghtRow-2; row++)
        {
            for (col = 2; col < lenghtCol-2; col++)
            {
                cellSum = GetCellSum(currentGenMatrix, row,col);
                //If exactly three neighbors are alive and the current cell is dead revive it on the next gen
                if (currentGenMatrix[row,col] == 0 && cellSum == 3)
                {
                        _nextGeneration[row, col] = 0;
                 
                }else if (currentGenMatrix[row,col] == 1 && cellSum < 2 || cellSum > 3)
                {
                    _nextGeneration[row, col] = 0; 
                }
            }
        }
        return _nextGeneration;
    }

    private int GetCellSum(int[,] currentGenMatrix, int row, int col)
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
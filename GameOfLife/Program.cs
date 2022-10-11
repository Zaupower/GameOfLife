using GameOfLife;

class Program
{
    static void Main(string[] args)
    {
        MatrixCalculator mtCalculator = new MatrixCalculator();
        int[,] initialMatrix = mtCalculator.GenMatrix(6+1);//add one to not counter borders
        int[,] nextGen = new int[initialMatrix.GetLength(0), initialMatrix.GetLength(1)];
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);

        GameOfLifeHelper gof = new GameOfLifeHelper();
        nextGen = gof.GenNextGeneration(initialMatrix);
        mtCalculator.PrintMatrix(nextGen);
        Console.WriteLine("");
        while (Console.ReadLine() != "exit")
        {
            nextGen = gof.GenNextGeneration(nextGen); 
            mtCalculator.PrintMatrix(nextGen);
            Console.WriteLine("");
        }
        
    }

}
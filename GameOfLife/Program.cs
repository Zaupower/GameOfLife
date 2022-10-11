using GameOfLife;

class Program
{
    static void Main(string[] args)
    {
        MatrixCalculator mtCalculator = new MatrixCalculator();
        //Use random generatos
        //int[,] initialMatrix = mtCalculator.GenMatrix(6+1);//add one to not counter borders
        
        //Beacon example
        int[,] initialMatrix =
        {
            {0,0,0,0,0,0}, 
            {0,1,1,0,0,0},
            {0,1,0,0,0,0},
            {0,0,0,0,1,0}, 
            {0,0,0,1,1,0},
            {0,0,0,0,0,0}
        };
        
        int[,] nextGen = new int[initialMatrix.GetLength(0), initialMatrix.GetLength(1)];
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);
        Console.WriteLine("First Gen");
        GameOfLifeHelper gof = new GameOfLifeHelper();
        nextGen = gof.GenNextGeneration(initialMatrix);
        mtCalculator.PrintMatrix(nextGen);
        Console.WriteLine("Press enter to show next generation, write \"exit\" to terminate ");
        
        while (Console.ReadLine() != "exit")
        {
            nextGen = gof.GenNextGeneration(nextGen); 
            mtCalculator.PrintMatrix(nextGen);
            Console.WriteLine("");
        }
        
    }

}
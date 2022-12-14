using GameOfLife;

class Program
{
    static void Main(string[] args)
    {
        MatrixCalculator mtCalculator = new MatrixCalculator();
        //Use random generatos
        int[,] initialMatrix = mtCalculator.GenMatrix(5,7);//add one to not counter borders
        
        //Beacon example
        /*
        int[,] initialMatrix =
        {
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0}, 
            {0,0,1,1,0,0,0,0},
            {0,0,1,0,0,0,0,0},
            {0,0,0,0,0,1,0,0}, 
            {0,0,0,0,1,1,0,0},
            {0,0,0,0,0,0,0,0},
            {0,0,0,0,0,0,0,0}
        };
        */
        int[,] nextGen = new int[initialMatrix.GetLength(0), initialMatrix.GetLength(1)];
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);
        Console.WriteLine("");
        Console.WriteLine("Press ENTER to generate next Gen or \"exit\" to leave");
        Console.WriteLine("");
        GameOfLifeHelper gof = new GameOfLifeHelper();
       
        while (Console.ReadLine() != "exit")
        {
            initialMatrix = gof.GenNextGeneration(initialMatrix); 
            mtCalculator.PrintMatrix(initialMatrix);
            Console.WriteLine("");
        }
    }
}
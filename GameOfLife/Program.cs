using GameOfLife;

class Program
{
    static void Main(string[] args)
    {
        MatrixCalculator mtCalculator = new MatrixCalculator();
        int[,] initialMatrix = mtCalculator.GenMatrix(6);
        
        Console.WriteLine("Initial matrix");
        mtCalculator.PrintMatrix(initialMatrix);
    }

}
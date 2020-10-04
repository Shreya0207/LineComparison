using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Line Comparison Computation.");
            LineComp line = new LineComp();
            double[] lineLength = new double[2];
            for (int numOfLines = 0; numOfLines < 2; numOfLines++)
            {
                lineLength[numOfLines] = line.CalculateLength();
            }
            line.CompareLength(lineLength[0], lineLength[1]);
        }
    }
}
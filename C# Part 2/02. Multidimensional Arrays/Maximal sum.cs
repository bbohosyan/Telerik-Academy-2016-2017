using System;

class Program
{
    static void Main()
    {
        string nAndM = Console.ReadLine();
        string[] numberNandM = nAndM.Split(' ');
        int rows = int.Parse(numberNandM[0]);
        int cols = int.Parse(numberNandM[1]);
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string currentLine = Console.ReadLine();
            string[] currentLineNumbers = currentLine.Split(' ');
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = int.Parse(currentLineNumbers[j]);
            }
        }
        int row = 0;
        int col = 0;
        int maxSum = int.MinValue;
        while (true)
        {
            int currentSum = 0;
            currentSum = array[row, col] + array[row + 1, col] + array[row + 2, col] + array[row, col + 1] + array[row + 1, col + 1]
            + array[row + 2, col + 1] + array[row, col + 2] + array[row + 1, col + 2] + array[row + 2, col + 2];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
            col++;
            if (col > cols - 3)
            {
                row++;
                col = 0;
            }

            if ((row == rows - 3) && (col == cols - 3))
            {
                break;
            }
        }
        Console.WriteLine(maxSum);
    }
}
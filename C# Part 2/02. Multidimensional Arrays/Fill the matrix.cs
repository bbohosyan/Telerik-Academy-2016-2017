using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char wayOfBuilding = char.Parse(Console.ReadLine());
        int[,] block = new int[n, n];
        int printNum = 1;
        if (wayOfBuilding == 'a')
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    block[j, i] = printNum;
                    printNum++;
                }
            }
        }
        else if (wayOfBuilding == 'b')
        {
            bool isUpToDown = true;
            for (int i = 0; i < n; i++)
            {
                if (isUpToDown == true)
                {
                    for (int j = 0; j < n; j++)
                    {
                        block[j, i] = printNum;
                        printNum++;
                    }
                    isUpToDown = false;
                }
                else
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        block[j, i] = printNum;
                        printNum++;
                    }
                    isUpToDown = true;
                }

            }
        }
        else if (wayOfBuilding == 'c')
        {
            for (int i = n - 1; i >= 0; i--)//n - 1 = 1,n - 2 = 2
            {
                int row = i;
                int col = 0;
                for (int j = 0; j < n - i; j++)
                {
                    block[row, col] = printNum;
                    printNum++;
                    row++;
                    col++;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                int row = 0;
                int col = i + 1;
                for (int j = 0; j < n - i - 1; j++)
                {
                    block[row, col] = printNum;
                    printNum++;
                    row++;
                    col++;
                }
            }
        }
        else if (wayOfBuilding == 'd')
        {
            char direction = 'd';
            int col = 0;
            int row = 0;
            for (int i = 0; i < n * n; i++)
            {
                if (direction == 'd')
                {
                    block[row, col] = i + 1;
                    row++;
                    if ((row == n) || (block[row, col] != 0))
                    {
                        direction = 'r';
                        row--;
                        col++;
                    }
                }
                else if (direction == 'r')
                {
                    block[row, col] = i + 1;
                    col++;
                    if ((col == n) || (block[row, col] != 0))
                    {
                        direction = 'u';
                        col--;
                        row--;
                    }

                }
                else if (direction == 'u')
                {
                    block[row, col] = i + 1;
                    row--;
                    if ((row == -1) || (block[row, col] != 0))
                    {
                        direction = 'l';
                        row++;
                        col--;
                    }

                }
                else if (direction == 'l')
                {
                    block[row, col] = i + 1;
                    col--;
                    if (block[row, col] != 0)
                    {
                        direction = 'd';
                        col++;
                        row++;
                    }

                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                Console.Write(block[i, j] + " ");
            }
            Console.Write(block[i, n - 1]);
            Console.WriteLine();
        }
    }
}
using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] spiralMatrix = new int[n, n];
        char way = 'r';
        int l = 0, r = 0, borderR = n, borderD = n, borderL = -1, borderU = 0;
        for (int i = 0; i < n * n; i++)
        {
            if (way == 'r')
            {
                spiralMatrix[l, r] = i + 1;
                r++;
                if (r == borderR)
                {
                    way = 'd';
                    r--;
                    l++;
                    borderR--;
                }
            }
            else if (way == 'd')
            {
                spiralMatrix[l, r] = i + 1;
                l++;
                if (l == borderD)
                {
                    way = 'l';
                    l--;
                    r--;
                    borderD--;
                }
            }
            else if (way == 'l')
            {
                spiralMatrix[l, r] = i + 1;
                r--;
                if (r == borderL)
                {
                    way = 'u';
                    l--;
                    r++;
                    borderL++;
                }
            }
            else if (way == 'u')
            {
                spiralMatrix[l, r] = i + 1;
                l--;
                if (l == borderU)
                {
                    borderU++;
                    way = 'r';
                    r++;
                    l++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
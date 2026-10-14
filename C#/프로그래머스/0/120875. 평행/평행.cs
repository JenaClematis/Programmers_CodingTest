using System;

public class Solution
{
    public int solution(int[,] dots)
    {
        int[,] indexs = new int[,] { {2, 3}, {1, 3}, {1, 2} };
        int[] x = new int[2], y = new int[2];
        
        for(int i = 1; i < dots.GetLength(0); i++)
        {
            x[0] = dots[0, 0] - dots[i, 0];
            y[0] = dots[0, 1] - dots[i, 1];
            x[1] = dots[indexs[i - 1, 0], 0] - dots[indexs[i - 1, 1], 0];
            y[1] = dots[indexs[i - 1, 0], 1] - dots[indexs[i - 1, 1], 1];
            
            if(x[1] * y[0] == x[0] * y[1])
                return 1;
        }
        
        return 0;
    }
}
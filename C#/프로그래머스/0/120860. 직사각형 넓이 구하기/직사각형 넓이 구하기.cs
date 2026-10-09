using System;
using System.Linq;

public class Solution
{
    public int solution(int[,] dots)
    {
        int[] x = new int[2], y = new int[2];
        
        x[0] = y[0] = 256;
        x[1] = y[1] = -256;
        
        for(int i = 0; i < dots.GetLength(0); i++)
        {
            x[0] = (dots[i, 0] < x[0]) ? dots[i, 0] : x[0];
            x[1] = (dots[i, 0] > x[1]) ? dots[i, 0] : x[1];
            y[0] = (dots[i, 1] < y[0]) ? dots[i, 1] : y[0];
            y[1] = (dots[i, 1] > y[1]) ? dots[i, 1] : y[1];
        }
        
        return (x[1] - x[0]) * (y[1] - y[0]);
    }
}
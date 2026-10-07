using System;

public class Solution
{
    public int[,] solution(int n)
    {
        int[,] answer = new int[n, n];
        int row = 0, col = 0, nextRow, nextCol;
        int num = 1, dir = 0;
        
        for(int i = 0; i < n * n ; i++)
        {
            answer[row, col] = num++;
            nextRow = dir == 1 ? row + 1 : dir == 3 ? row - 1 : row;
            nextCol = dir == 0 ? col + 1 : dir == 2 ? col - 1 : col;
            
            if(nextRow >= n || nextRow <= -1 || nextCol >= n || nextCol <= -1
                || answer[nextRow, nextCol] != 0)
            {
                dir = (dir + 1) % 4;
                row = dir == 1 ? row + 1 : dir == 3 ? row - 1 : row;
                col = dir == 0 ? col + 1 : dir == 2 ? col - 1 : col;
                continue;
            }
            
            row = nextRow;
            col = nextCol;
        }
        
        return answer;
    }
}
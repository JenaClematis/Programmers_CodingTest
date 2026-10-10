using System;

public class Solution
{
    public int solution(int[,] board)
    {
        int rowLength = board.GetLength(0), colLength = board.GetLength(1), answer = 0;
        
        for(int i = 0; i < rowLength; i++)
            for(int j = 0; j < colLength; j++)
            {
                if(board[i, j] != 1)
                    continue;
                
                for(int row = i - 1; row < i + 2; row++)
                    for(int col = j - 1; col < j + 2; col++)
                    {
                        if(row < 0 || row > rowLength - 1 || col < 0 || col > colLength - 1)
                            continue;
                        
                        board[row, col] = board[row, col] == 0 ? -1 : board[row, col];
                    }
            }
        
        for(int i = 0; i < board.GetLength(0); i++)
            for(int j = 0; j < board.GetLength(1); j++)
                answer += board[i, j] == 0 ? 1 : 0;
        
        return answer;
    }
}
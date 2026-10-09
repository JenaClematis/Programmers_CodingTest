using System;

public class Solution
{
    public int[] solution(string[] keyinput, int[] board)
    {
        int[] answer = new int[2];
        int limitX = (board[0] - 1) / 2, limitY = (board[1] - 1) / 2;
        
        for(int i = 0; i < keyinput.Length; i++)
        {
            switch(keyinput[i])
            {
                case "left":
                    answer[0] = Math.Max(-limitX, answer[0] - 1);
                    break;
                case "right":
                    answer[0] = Math.Min(limitX, answer[0] + 1);
                    break;
                case "down":
                    answer[1] = Math.Max(-limitY, answer[1] - 1);
                    break;
                case "up":
                    answer[1] = Math.Min(limitY, answer[1] + 1);
                    break;
            }
        }
        
        return answer;
    }
}
using System;

public class Solution
{
    public int solution(int[,] arr)
    {
        int answer = 0;
        
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if(arr[i, j] != arr[j, i])
                {
                    answer = 0;
                    break;
                }
                
                answer = 1;
            }
            
            if(answer == 0)
                break;
        }
        
        return answer;
    }
}
using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = arr;
        int start, end;
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            start = queries[i, 0];
            end = queries[i, 1];
            
            for(int j = start; j < end + 1; j++)
                answer[j]++;
        }
        
        return answer;
    }
}
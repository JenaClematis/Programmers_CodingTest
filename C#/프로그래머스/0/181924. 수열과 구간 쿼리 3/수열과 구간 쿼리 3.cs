using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = arr;
        int temp;
        
        /*
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            for(int j = 0; j < queries.GetLength(1); j++)
                Console.Write($"[ {i}, {j} ] = {queries[i, j]} ");
            
            Console.WriteLine();
        }
        */
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            temp = answer[queries[i, 0]];
            answer[queries[i, 0]] = answer[queries[i, 1]];
            answer[queries[i, 1]] = temp;
        }
        
        return answer;
    }
}
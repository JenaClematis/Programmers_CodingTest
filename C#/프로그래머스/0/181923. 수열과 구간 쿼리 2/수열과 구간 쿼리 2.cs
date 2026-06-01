using System;

public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        /*
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            for(int j = 0; j < queries.GetLength(1); j++)
                Console.Write($"[ {i}, {j} ] = {queries[i, j]} ");
            
            Console.WriteLine();
        }
        */
        
        int[] answer = new int[queries.GetLength(0)];
        int min = int.MaxValue;
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            min = int.MaxValue;
            
            for(int c = queries[i, 0]; c <= queries[i, 1]; c++)
                if(arr[c] > queries[i, 2] && arr[c] < min)
                    min = arr[c];
            
            answer[i] = min == int.MaxValue ? -1 : min;
        }
        
        return answer;
    }
}
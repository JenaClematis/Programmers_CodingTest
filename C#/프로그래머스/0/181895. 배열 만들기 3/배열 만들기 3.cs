using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[,] intervals)
    {
        /*
        for(int i = 0; i < intervals.GetLength(0); i++)
        {
            for(int j = 0; j < intervals.GetLength(1); j++)
                Console.Write($"[ {i}, {j} ] = {intervals[i, j]} ");
            
            Console.WriteLine();
        }
        */
        
        List<int> answer = new List<int>();
        
        for(int i = 0; i < intervals.GetLength(0); i++)
            for(int index = intervals[i, 0]; index <= intervals[i, 1]; index++)
                answer.Add(arr[index]);
        
        return answer.ToArray();
    }
}
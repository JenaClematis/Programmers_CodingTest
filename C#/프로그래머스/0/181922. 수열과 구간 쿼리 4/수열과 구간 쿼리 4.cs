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
                
        // i가 k의 배수
        int[] answer = arr;
        
        for(int index = 0; index < queries.GetLength(0); index++)
            for(int i = queries[index, 0]; i <= queries[index, 1]; i++)
                if(i % queries[index, 2] == 0)
                    answer[i]++;
        
        return answer;
    }
}
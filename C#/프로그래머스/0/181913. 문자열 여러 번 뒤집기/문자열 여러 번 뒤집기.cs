using System;

public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        /*
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            for(int j = 0; j < queries.GetLength(1); j++)
                Console.Write($"[ {i}, {j} ] = {queries[i, j]} ");
            
            Console.WriteLine();
        }
        */
        
        /*
        string answer = my_string;
        char[] target;
        int start, end;
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            start = queries[i, 0];
            end = queries[i, 1] - start + 1;
            
            target = answer.Substring(start, end).ToCharArray();
            Array.Reverse(target);
            
            answer = answer.Remove(start, end).Insert(start, string.Join("", target));
        }
        */

        char[] answer = my_string.ToCharArray();
        int start, end;
        
        for(int i = 0; i < queries.GetLength(0); i++)
        {
            start = queries[i, 0];
            end = queries[i, 1] - start + 1;
            Array.Reverse(answer, start, end);
        }
        
        return string.Join("", answer);
    }
}
using System;

public class Solution
{
    public string solution(string[] my_strings, int[,] parts)
    {
        /*
        for(int i = 0; i < parts.GetLength(0); i++)
        {
            for(int j = 0; j < parts.GetLength(1); j++)
                Console.Write($"[ {i}, {j} ] = {parts[i, j]} ");
            
            Console.WriteLine();
        }
        */
        
        // start = parts[i, 0] | end = parts[i, 1]
        string answer = "";
        
        for(int i = 0; i < my_strings.Length; i++)
            answer += my_strings[i].Substring(parts[i, 0], parts[i, 1] - parts[i, 0] + 1);
        
        return answer;
    }
}
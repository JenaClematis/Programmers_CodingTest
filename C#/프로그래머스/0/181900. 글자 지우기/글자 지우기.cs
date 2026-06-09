using System;

public class Solution
{
    public string solution(string my_string, int[] indices)
    {
        char[] answer = my_string.ToCharArray();
        
        for(int i = 0; i < indices.Length; i++)
            answer[indices[i]] = '.';
        
        return string.Join("", answer).Replace(".", "");
    }
}
using System;

public class Solution
{
    public string solution(string my_string)
    {
        char[] answer = my_string.ToCharArray();
        
        for(int i = 0; i < answer.Length; i++)
            answer[i] = Char.IsLower(answer[i]) ? Char.ToUpper(answer[i]) : Char.ToLower(answer[i]);
        
        return String.Join("", answer);
    }
}
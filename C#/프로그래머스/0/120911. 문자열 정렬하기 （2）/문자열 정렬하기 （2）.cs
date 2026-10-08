using System;

public class Solution
{
    public string solution(string my_string)
    {
        string str = my_string.ToLower();
        char[] answer = str.ToCharArray();
        
        answer.Sort();
        
        return String.Join("", answer);
    }
}
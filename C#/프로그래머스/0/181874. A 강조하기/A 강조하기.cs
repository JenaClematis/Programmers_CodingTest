using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = myString;
        
        answer = answer.ToLower();
        
        return answer.Replace("a", "A");
    }
}
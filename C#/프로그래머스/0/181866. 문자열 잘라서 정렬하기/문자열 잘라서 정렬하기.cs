using System;

public class Solution
{
    public string[] solution(string myString)
    {
        string[] answer = myString.Split("x", myString.Length, StringSplitOptions.RemoveEmptyEntries);
        
        answer.Sort();
        
        return answer;
    }
}
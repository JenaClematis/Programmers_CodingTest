using System;

public class Solution
{
    public string[] solution(string myStr)
    {
        string[] answer = myStr.Split(["a", "b", "c"], StringSplitOptions.RemoveEmptyEntries);
        
        if(answer.Length == 0)
            answer = new string[] {"EMPTY"};
        
        return answer;
    }
}
using System;

public class Solution
{
    public string[] solution(string[] strArr)
    {
        string[] answer = strArr;
        
        for(int i = 0; i < answer.Length; i++)
            answer[i] = i % 2 == 0 ? answer[i].ToLower() : answer[i].ToUpper();
        
        return answer;
    }
}
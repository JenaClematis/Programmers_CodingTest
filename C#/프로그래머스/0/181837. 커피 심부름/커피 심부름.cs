using System;

public class Solution
{
    public int solution(string[] order)
    {
        int answer = 0;
        
        for(int i = 0; i < order.Length; i++)
            answer += (order[i].Contains("any") || order[i].Contains("ame")) ? 4500 : 5000;
        
        return answer;
    }
}
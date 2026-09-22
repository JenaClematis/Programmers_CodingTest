using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0, index = 0;
        
        while(true)
        {
            if((index = myString.IndexOf(pat, index) + 1) == 0)
                break;
            
            answer++;
        }
        
        return answer;
    }
}
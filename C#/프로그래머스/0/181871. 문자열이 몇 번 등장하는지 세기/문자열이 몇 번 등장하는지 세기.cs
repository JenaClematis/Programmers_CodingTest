using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        int answer = 0, index = 0;
        
        while(true)
        {
            if(myString.IndexOf(pat, index) == -1)
                break;
            
            index = myString.IndexOf(pat, index) + 1;
            answer++;
        }
        
        return answer;
    }
}
using System;

public class Solution
{
    public int solution(string[] s1, string[] s2)
    {
        int answer = 0;
        bool longS1 = s1.Length > s2.Length;
        int length = s1.Length > s2.Length ? s2.Length : s1.Length;
        
        for(int i = 0; i < length; i++)
        {
            if(longS1)
                answer += s1.Contains(s2[i]) ? 1 : 0;
            else
                answer += s2.Contains(s1[i]) ? 1 : 0;
        }
        
        return answer;
    }
}
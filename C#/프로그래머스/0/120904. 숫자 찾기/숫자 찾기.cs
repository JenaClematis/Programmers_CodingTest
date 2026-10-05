using System;

public class Solution
{
    public int solution(int num, int k)
    {
        string str = num.ToString();
        int answer = 0;
        
        for(int i = 0; i < str.Length; i++)
            if(str[i].ToString().Equals(k.ToString()))
            {
                answer = i + 1;
                break;
            }
        
        return answer == 0 ? -1 : answer;
    }
}
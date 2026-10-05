using System;

public class Solution
{
    public int solution(int n)
    {
        string str = n.ToString();
        int answer = 0;
        
        for(int i = 0; i < str.Length; i++)
            answer += Int32.Parse(str[i].ToString());
        
        return answer;
    }
}
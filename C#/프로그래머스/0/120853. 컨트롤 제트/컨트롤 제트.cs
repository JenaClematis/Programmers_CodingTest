using System;

public class Solution
{
    public int solution(string s)
    {
        int answer = 0;
        string[] str = s.Split(" ");
        
        for(int i = 0; i < str.Length; i++)
        {
            if(Int32.TryParse(str[i], out int num))
                answer += num;
            else
                answer -= Int32.Parse(str[i - 1]);
        }
        
        return answer;
    }
}
using System;

public class Solution
{
    public int solution(string binomial)
    {
        string[] str = binomial.Split(" ");
        int answer = 0;
        
        if(str[1].Equals("+"))
            answer = Convert.ToInt32(str[0]) + Convert.ToInt32(str[2]);
        else if(str[1].Equals("-"))
            answer = Convert.ToInt32(str[0]) - Convert.ToInt32(str[2]);
        else
            answer = Convert.ToInt32(str[0]) * Convert.ToInt32(str[2]);
        
        return answer;
    }
}
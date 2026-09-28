using System;

public class Solution
{
    public int solution(int order)
    {
        string str = order.ToString();
        int answer = 0, num = 0;
        
        for(int i = 0; i < str.Length; i++)
        {
            num = Int32.Parse(str[i].ToString());
            answer += (num % 3 == 0 && num != 0) ? 1 : 0;
        }
        
        return answer;
    }
}
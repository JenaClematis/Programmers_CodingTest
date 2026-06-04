using System;

public class Solution
{
    public int solution(string number)
    {
        int answer = 0;
        
        for(int i = 0; i < number.Length; i++)
            answer += Int32.Parse(number[i].ToString());
        
        return answer % 9;
    }
}
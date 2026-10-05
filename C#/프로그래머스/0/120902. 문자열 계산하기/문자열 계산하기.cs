using System;

public class Solution
{
    public int solution(string my_string)
    {
        string[] str = my_string.Split(" ");
        int answer = Int32.Parse(str[0]);
        int num = 0;
        
        for(int i = 1; i < str.Length; i += 2)
        {
            num = Int32.Parse(str[i + 1]);
            answer += str[i] == "+" ? num : -num;
        }
        
        return answer;
    }
}
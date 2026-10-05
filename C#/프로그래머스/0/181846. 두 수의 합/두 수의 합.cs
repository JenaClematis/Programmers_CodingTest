using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string a, string b)
    {
        List<int> answer = new List<int>();
        int length = a.Length > b.Length ? a.Length : b.Length;
        int num = 0, remain = 0;
        
        for(int i = 0; i < length; i++)
        {
            num = remain;
            
            num += i < a.Length ? a[a.Length - (i + 1)] - '0' : 0;
            num += i < b.Length ? b[b.Length - (i + 1)] - '0' : 0;
            
            answer.Add(num % 10);
            remain = num / 10;
        }
        
        if(remain != 0)
            answer.Add(remain);
        
        answer.Reverse();
        
        return String.Join("", answer);
    }
}
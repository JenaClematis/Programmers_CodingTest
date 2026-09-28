using System;
using System.Collections.Generic;

public class Solution
{
    public string solution(string s)
    {
        Dictionary<char, int> str = new Dictionary<char, int>();
        
        for(int i = 0; i < s.Length; i++)
        {
            if(!str.ContainsKey(s[i]))
            {
                str.Add(s[i], 1);
                continue;
            }
            
            str[s[i]]++;
        }
        
        List<char> answer = new List<char>();
        
        foreach(var pair in str)
            if(pair.Value == 1)
                answer.Add(pair.Key);
        
        answer.Sort();
        
        return String.Join("", answer.ToArray());
    }
}
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        // start = s | length = l | k보다 큼
        List<int> answer = new List<int>();
        int num;
        
        foreach(string str in intStrs)
        {
            num = Int32.Parse(str.Substring(s, l));
            
            if(num > k)
                answer.Add(num);
        }
        
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        List<int> answer = new List<int>();
        
        answer.Add(1);
        
        if(!answer.Contains(n))
            answer.Add(n);
        
        for(int i = 2; i * i < n + 1; i++)
            if(n % i == 0)
            {
                if(!answer.Contains(i))
                    answer.Add(i);
                
                if(!answer.Contains(n / i))
                    answer.Add(n / i);
            }
        
        answer.Sort();
        
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        int num = n;
        List<int> answer = new List<int>();
        
        for(int i = 2; i * i < num + 1; i++)
        {
            if(num % i == 0)
            {
                answer.Add(i);
                
                while(num % i == 0)
                    num /= i;
            }
        }
        
        if(num > 1)
            answer.Add(num);
        
        return answer.ToArray();
    }
}
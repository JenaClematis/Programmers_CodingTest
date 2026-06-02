using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int l, int r)
    {
        List<int> answer = new List<int>();
        string number;
        bool equal;
        
        for(int i = l; i <= r; i++)
        {
            if(i % 5 != 0)
                continue;
            
            number = i.ToString();
            equal = false;
            
            for(int j = 0; j < number.Length; j++)
            {
                if(number[j].Equals('0') || number[j].Equals('5'))
                {
                    equal = true;
                    continue;
                }
                
                equal = false;
                break;
            }
            
            if(equal)
                answer.Add(i);
        }
        
        if(answer.Count == 0)
            answer.Add(-1);
        
        return answer.ToArray();
    }
}
using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        List<int> counts = new List<int>();
        
        Array.Sort(array);
        
        foreach(int val in array)
        {
            if(counts.Count != val + 1)
                for(int i = counts.Count; i <= val ; i++)
                {
                    if(i == val)
                        counts.Add(1);
                    else
                        counts.Add(0);
                }
            else
                counts[val]++;
        }
        
        bool flag = false;
        
        for(int i = 1; i < counts.Count; i++)
        {
            if(counts[i] > counts[answer])
            {
                flag = false;
                answer = i;
            }
            else if(counts[i] == counts[answer])
                flag = true;
        }
        
        if(flag)
            return -1;
        
        return answer;
    }
}
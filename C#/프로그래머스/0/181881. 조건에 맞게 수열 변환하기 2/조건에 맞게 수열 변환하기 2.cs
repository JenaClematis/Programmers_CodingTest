using System;

public class Solution
{
    public int solution(int[] arr)
    {
        int[] cur = arr;
        int[] prev = new int[cur.Length];
        bool correct = true;
        int count = 0;
        
        while(true)
        {
            correct = true;
            
            for(int i = 0; i < cur.Length; i++)
            {
                prev[i] = cur[i];
                
                if(cur[i] >= 50)
                {
                    cur[i] /= cur[i] % 2 == 0 ? 2 : 1;
                    continue;
                }
                
                cur[i] = cur[i] % 2 != 0 ? cur[i] * 2 + 1 : cur[i];
            }
            
            for(int i = 0; i < cur.Length; i++)
                if(prev[i] != cur[i])
                {
                    correct = false;
                    break;
                }
            
            if(correct)
                break;
            else
                count++;
        }
        
        return count;
    }
}
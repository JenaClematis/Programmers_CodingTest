using System;

public class Solution
{
    public int[] solution(int n)
    {
        int count;
        
        if(n % 2 != 0)
            count = n / 2 + 1;
        else
            count = n / 2;
        
        int[] answer = new int[count];
        count = 0;
        
        for(int i = 1; i <= n; i += 2)
        {
            answer[count++] = i;
            
            if(count > answer.Length)
                break;
        }
        
        return answer;
    }
}
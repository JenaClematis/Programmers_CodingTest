using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        int num = 0;
        
        for(int i = 2; i < 11; i++)
        {
            num = Fact(i);
            answer = n > num ? 0 : (n < num ? i - 1 : i);
            
            if(answer > 0)
                break;
        }
        
        return answer;
    }
    
    private int Fact(int n)
    {
        if(n == 1 || n == 2)
            return n;
        
        return n * Fact(n - 1);
    }
}
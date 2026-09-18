using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        
        for(int i = 2; i < n + 1; i++)
            if((i % 2 == 0 && i != 2) || (i % 3 == 0 && i != 3)
                || (i % 5 == 0 && i != 5) || (i % 7 == 0 && i != 7))
                answer++;
        
        return answer;
    }
}
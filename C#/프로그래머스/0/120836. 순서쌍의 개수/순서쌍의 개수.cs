using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        
        for(int i = 1; i * i <= n; i++)
            answer += n % i != 0 ? 0 : n / i != i ? 2 : 1;
        
        return answer;
    }
}
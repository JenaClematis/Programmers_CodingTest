using System;

public class Solution
{
    public int solution(int balls, int share)
    {
        return Combine(balls, share);
    }
    
    // 팩토리얼도 가능하지만, int의 최대 범위를 벗어남
    // 파스칼의 삼각형
    public int Combine(int b, int s)
    {
        if(s == 0 || b == s)
            return 1;
        
        return Combine(b - 1, s - 1) + Combine(b - 1, s);
    }
}
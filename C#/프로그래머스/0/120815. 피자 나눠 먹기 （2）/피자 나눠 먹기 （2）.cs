using System;

public class Solution
{
    public int solution(int n)
    {
        return n / GCD(Math.Max(n, 6), Math.Min(n, 6));
    }
    
    public int GCD(int a, int b)
    {
        int temp;
        
        while(b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
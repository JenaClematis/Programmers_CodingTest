using System;

public class Solution
{
    public double solution(int[] numbers)
    {
        int add = 0;
        
        foreach(int num in numbers)
            add += num;
        
        return (double)add / numbers.Length;
    }
}
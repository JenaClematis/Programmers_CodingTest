using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int mul = 1;
        int pow = 0;
        
        foreach(int num in num_list)
        {
            mul *= num;
            pow += num;
        }
        
        return mul > pow * pow ? 0 : 1;
    }
}
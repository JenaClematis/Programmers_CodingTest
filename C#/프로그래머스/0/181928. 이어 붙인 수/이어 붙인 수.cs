using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        string odd = "";
        string even = "";
        
        foreach(int num in num_list)
        {
            if(num % 2 == 0)
                even += num;
            else
                odd += num;
        }
        
        return Int32.Parse(odd) + Int32.Parse(even);
    }
}
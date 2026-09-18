using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int odd = 0, even = 0;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            odd += i % 2 == 0 ? num_list[i] : 0;
            even += i % 2 != 0 ? num_list[i] : 0;
        }
        
        return odd >= even ? odd : even;
    }
}
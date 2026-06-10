using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        // Array.FindIndex가 있구나?
        for(int i = 0; i < num_list.Length; i++)
            if(num_list[i] < 0)
                return i;
        
        return -1;
    }
}
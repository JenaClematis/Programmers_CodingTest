using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        bool flag = num_list.Length > 10;
        int answer = flag ? 0 : 1;
        
        for(int i = 0; i < num_list.Length; i++)
        {
            if(flag)
                answer += num_list[i];
            else
                answer *= num_list[i];
        }
        
        return answer;
    }
}
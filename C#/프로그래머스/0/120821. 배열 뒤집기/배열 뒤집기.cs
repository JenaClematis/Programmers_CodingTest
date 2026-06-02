using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = num_list;
        Array.Reverse(answer);
        return answer;
    }
}
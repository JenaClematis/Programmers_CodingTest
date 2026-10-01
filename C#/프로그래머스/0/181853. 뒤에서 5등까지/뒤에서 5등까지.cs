using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[5];
        
        num_list.Sort();
        Array.Copy(num_list, answer, answer.Length);
        
        return answer;
    }
}
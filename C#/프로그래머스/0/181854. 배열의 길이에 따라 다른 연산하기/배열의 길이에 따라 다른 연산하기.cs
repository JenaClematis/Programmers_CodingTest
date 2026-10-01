using System;

public class Solution
{
    public int[] solution(int[] arr, int n)
    {
        int[] answer = arr;
        
        for(int i = answer.Length % 2 == 0 ? 1 : 0; i < answer.Length; i += 2)
            answer[i] += n;
        
        return answer;
    }
}
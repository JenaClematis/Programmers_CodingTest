using System;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int[] answer = arr;
        bool isOdd = k % 2 != 0;
        
        for(int i = 0; i < arr.Length; i++)
            answer[i] = isOdd ? answer[i] * k : answer[i] + k;
        
        return answer;
    }
}
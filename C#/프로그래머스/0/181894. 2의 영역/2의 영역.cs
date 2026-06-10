using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int first = Array.FindIndex(arr, 0, val => val == 2);
        int last = Array.FindLastIndex(arr, arr.Length - 1, val => val == 2);
        
        if(first == -1)
            return new int[] {-1};
        
        int[] answer = new int[(last > 0 ? last - first + 1 : 1)];
        
        Array.Copy(arr, first, answer, 0, answer.Length);
        
        return answer;
    }
}
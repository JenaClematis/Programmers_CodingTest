using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr, int[] delete_list)
    {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < arr.Length; i++)
            answer.Add(arr[i]);
        
        for(int i = 0; i < delete_list.Length; i++)
            answer.Remove(delete_list[i]);
        
        return answer.ToArray();
    }
}
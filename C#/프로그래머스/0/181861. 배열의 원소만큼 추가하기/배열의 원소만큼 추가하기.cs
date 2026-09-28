using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int size = 0;
        
        for(int i = 0; i < arr.Length; i++)
            size += arr[i];
        
        int[] answer = new int[size];
        int index = 0;
        
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr[i]; j++)
                answer[j + index] = arr[i];
            
            index += arr[i];
        }
        
        return answer;
    }
}
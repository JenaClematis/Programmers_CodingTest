using System;

public class Solution
{
    public int[] solution(int[] arr, int k)
    {
        int[] answer = new int[k];
        int index = 0;
        
        for(int i = 0; i < k; i++)
            answer[i] = -1;
        
        for(int i = 0; i < arr.Length; i++)
        {
            if(Array.Exists(answer, num => num == arr[i]))
                continue;
            
            answer[index++] = arr[i];
            
            if(index >= k)
                break;
        }
        
        return answer;
    }
}
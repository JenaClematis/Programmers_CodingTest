using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer = arr;
        
        for(int i = 0; i < answer.Length; i++)
        {
            if(answer[i] >= 50)
            {
                answer[i] /= answer[i] % 2 == 0 ? 2 : 1;
                continue;
            }
            
            answer[i] *= answer[i] % 2 != 0 ? 2 : 1;
        }
        
        return answer;
    }
}
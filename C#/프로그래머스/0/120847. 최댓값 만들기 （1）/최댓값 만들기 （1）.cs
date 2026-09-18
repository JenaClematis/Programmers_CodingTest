using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int answer = 0, index = 0;
        
        for(int i = 0; i < numbers.Length; i++)
            index = numbers[i] > numbers[index] ? i : index;
        
        for(int i = 0; i < numbers.Length; i++)
        {
            if(i == index)
                continue;
            
            answer = Math.Max(answer, numbers[i] * numbers[index]);
        }
        
        return answer;
    }
}
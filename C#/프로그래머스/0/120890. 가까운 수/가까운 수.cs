using System;

public class Solution
{
    public int solution(int[] array, int n)
    {
        int index = 0, num1 = 0, num2 = 0;
        
        for(int i = array.Length - 1; i >= 0; i--)
        {
            if(index == 0)
            {
                index = i;
                continue;
            }
            
            num1 = Math.Abs(array[index] - n);
            num2 = Math.Abs(array[i] - n);
            
            if(num1 > num2 || num1 == num2 && array[index] > array[i])
                index = i;
        }
                
        
        return array[index];
    }
}
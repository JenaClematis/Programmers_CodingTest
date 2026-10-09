using System;

public class Solution
{
    public int solution(int[] numbers)
    {
        int[] num = numbers;
        int num1, num2;
        
        num.Sort();
        num1 = num[0] * num[1];
        num2 = num[num.Length - 1] * num[num.Length - 2];
        
        return num1 > num2 ? num1 : num2;
    }
}
using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] numbers, int num1, int num2)
    {
        return numbers.Where((num, index) => index >= num1 && index <= num2).ToArray();
    }
}
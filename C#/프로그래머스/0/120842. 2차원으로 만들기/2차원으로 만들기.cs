using System;

public class Solution
{
    public int[,] solution(int[] num_list, int n)
    {
        // CreateInstance(Type, length1, length2)
        // n == 2 일 때 -> i, j == i : 0 ~ 3, j : 0 ~ 1
        Array answer = Array.CreateInstance(typeof(int), num_list.Length / n, n);
        
        for(int i = 0; i < num_list.Length; i++)
                answer.SetValue(num_list[i], i / n, i % n);
        
        return (int[,])answer;
    }
}
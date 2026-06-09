using System;

public class Solution
{
    public int solution(int[] arr, int idx)
    {
        // index >= idx && arr[index] == 1
        // 가장 작은 index == 제일 먼저 발견되는 index
        return Array.FindIndex(arr, idx, val => val == 1);
    }
}
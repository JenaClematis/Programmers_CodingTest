using System;

public class Solution
{
    public int solution(int n, int k)
    {
        // 10인분 -> 음료수 1개 | 1인분 == 12000원 | 1개 == 2000원
        return n * 12000 + (k - n / 10) * 2000;
    }
}
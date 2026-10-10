using System;

public class Solution
{
    public int solution(int[] sides)
    {
        // sides 원소가 최댓값일 때 범위 : max - (max - min + 1) == min
        // 미지수 X가 최댓값일 때 범위 : max + min - 1 - (max + 1) == min - 1
        int min = sides[0] < sides[1] ? sides[0] : sides[1];
        
        return 2 * min - 1;
    }
}
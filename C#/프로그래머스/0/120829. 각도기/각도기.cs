using System;

public class Solution
{
    public int solution(int angle)
    {
        // 90 > 예각 > 0 | 90 == 직각 | 180 > 둔각 > 90 | 180 == 평각
        return angle == 180 ? 4 : angle > 90 ? 3 : angle == 90 ? 2 : 1;
    }
}
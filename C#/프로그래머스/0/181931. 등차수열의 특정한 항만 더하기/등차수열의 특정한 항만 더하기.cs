using System;

public class Solution
{
    public int solution(int a, int d, bool[] included)
    {
        // 등차수열 : 첫째항 a, 공차 b == 둘째항 a + b * 1, 셋째항 a + b * 2
        int answer = 0;
        
        for(int i = 0; i < included.Length; i++)
            if(included[i])
                answer += a + d * i;
        
        return answer;
    }
}
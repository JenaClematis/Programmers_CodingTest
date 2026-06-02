using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int n)
    {
        // 짝수 -> / 2 | 홀수 -> * 3 + 1
        // n이 1이 될때까지
        List<int> answer = new List<int>();
        int num = n;
        answer.Add(num);
        
        while(num != 1)
        {
            if(num % 2 == 0)
                num /= 2;
            else
                num = num * 3 + 1;

            answer.Add(num);
        }
        
        return answer.ToArray();
    }
}
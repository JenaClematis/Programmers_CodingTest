using System;

public class Solution
{
    public int[] solution(int n, int k)
    {
        // Linq -> Enumerable 이건 몰랐네...
        int[] answer = new int[n / k];
        int index = 0;
        
        for(int i = k; i <= n; i += k)
            answer[index++] = i;
        
        return answer;
    }
}
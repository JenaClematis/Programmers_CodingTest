using System;

public class Solution
{
    public int solution(int[] num_list)
    {
        int[] num = num_list;
        int index = 0, answer = 0;
        
        for(int i = 0; i < num.Length; i++)
            while(num[i] != 1)
            {
                // 홀수를 2로 나누면 X.5가 되고 정수이기 때문에 .5는 버리므로, -1 과정 생략
                num[i] /= 2;
                answer++;
            }
        
        return answer;
    }
}
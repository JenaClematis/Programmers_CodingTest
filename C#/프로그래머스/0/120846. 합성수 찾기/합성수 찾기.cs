using System;

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        
        // 약수는 쌍으로 존재하기 때문에 제곱을 통해 확인 범위를 제한할 수 있음
        for(int i = 4; i < n + 1; i++)
            for(int j = 2; j * j < i + 1; j++)
                if(i % j == 0)
                {
                    answer++;
                    break;
                }
        
        /*
        for(int i = 4; i < n + 1; i++)
            if(i % 2 == 0 || i % 3 == 0
                || (i % 5 == 0 && i != 5) || (i % 7 == 0 && i != 7))
                answer++;
        */
        
        return answer;
    }
}

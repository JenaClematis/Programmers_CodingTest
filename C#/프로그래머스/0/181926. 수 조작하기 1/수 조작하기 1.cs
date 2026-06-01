using System;

public class Solution
{
    public int solution(int n, string control)
    {
        // w -> n++ / s -> n-- / d -> n += 10 / a -> n -= 10
        int answer = n;
        
        for(int i = 0; i < control.Length; i++)
            switch(control[i])
            {
                case 'w':
                    answer++;
                    break;
                case 's':
                    answer--;
                    break;
                case 'd':
                    answer += 10;
                    break;
                case 'a':
                    answer -= 10;
                    break;
            }
        
        return answer;
    }
}
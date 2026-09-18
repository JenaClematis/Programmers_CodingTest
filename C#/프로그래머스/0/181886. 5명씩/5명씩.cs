using System;

public class Solution
{
    public string[] solution(string[] names)
    {
        // 정수 나눗셈에 올림 효과 추가 방법 : N + 나누는 수 - 1
        int length = (names.Length + 4) / 5;
        string[] answer = new string[length];
        
        for(int i = 0; i < length; i++)
            answer[i] = names[5 * i];
        
        return answer;
    }
}
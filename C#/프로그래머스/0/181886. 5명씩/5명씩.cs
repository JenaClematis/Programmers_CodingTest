using System;

public class Solution
{
    public string[] solution(string[] names)
    {
        // 정수 나눗셈에 올림 효과 추가 방법 : N + 나누는 수 - 1
        // 5의 배수인가 아닌가로 나눠서 /5 : /5 + 1 하는 방법도 있었음
        int length = (names.Length + 4) / 5;
        string[] answer = new string[length];
        
        for(int i = 0; i < length; i++)
            answer[i] = names[5 * i];
        
        return answer;
    }
}
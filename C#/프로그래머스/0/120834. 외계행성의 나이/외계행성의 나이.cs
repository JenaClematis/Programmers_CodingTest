using System;

public class Solution
{
    public string solution(int age)
    {
        // a == 0 | b == 1 | c == 2 | ... | j == 9
        // 97
        char[] answer = age.ToString().ToCharArray();
        
        for(int i = 0; i < answer.Length; i++)
            answer[i] += (char)49;
        
        return string.Join("", answer);
    }
}
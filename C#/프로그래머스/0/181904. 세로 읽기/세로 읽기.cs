using System;

public class Solution
{
    public string solution(string my_string, int m, int c)
    {
        // 1, 5, 9, 13, 17
        // m * 0 + c - 1, m * 1 + c - 1
        string answer = "";
        char[] ch = my_string.ToCharArray();
        
        // char[]로 변환 안하고 그냥 string[index]로도 되는 걸 잊었네;
        for(int i = 0; i < ch.Length / m; i++)
            answer += ch[m * i + c - 1];
        
        return answer;
    }
}
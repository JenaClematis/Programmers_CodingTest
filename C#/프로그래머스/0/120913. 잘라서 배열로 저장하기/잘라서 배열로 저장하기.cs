using System;

public class Solution
{
    public string[] solution(string my_str, int n)
    {
        string[] answer = new string[my_str.Length / n + (my_str.Length % n != 0 ? 1 : 0)];
        int length = n;
        
        for(int i = 0; i < answer.Length; i++)
        {
            answer[i] = my_str.Substring(i * n, length);
            length = (i * n) + n * 2 > my_str.Length ? my_str.Length % n : n;
        }
        
        return answer;
    }
}
using System;

public class Solution
{
    public int[] solution(string myString)
    {
        string[] str = myString.Split("x", myString.Length);
        int[] answer = new int[str.Length];
        
        for(int i = 0; i < str.Length; i++)
            answer[i] = str[i].Length;
        
        return answer;
    }
}
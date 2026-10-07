using System;

public class Solution
{
    public string solution(string myString)
    {
        string answer = "";
        
        for(int i = 0; i < myString.Length; i++)
            answer += (int)myString[i] < (int)'l' ? "l" : myString[i];
        
        return answer;
    }
}
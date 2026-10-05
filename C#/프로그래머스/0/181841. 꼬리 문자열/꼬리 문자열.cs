using System;

public class Solution
{
    public string solution(string[] str_list, string ex)
    {
        string answer = "";
        
        for(int i = 0; i < str_list.Length; i++)
            answer += str_list[i].Contains(ex) ? "" : str_list[i];
        
        return answer;
    }
}
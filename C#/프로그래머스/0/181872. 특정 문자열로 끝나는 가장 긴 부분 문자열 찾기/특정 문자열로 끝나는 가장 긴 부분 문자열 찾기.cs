using System;

public class Solution
{
    public string solution(string myString, string pat)
    {
        string answer = "";
        
        if(myString.Contains(pat))
            answer = myString.Substring(0, myString.LastIndexOf(pat) + pat.Length);
        
        return answer;
    }
}
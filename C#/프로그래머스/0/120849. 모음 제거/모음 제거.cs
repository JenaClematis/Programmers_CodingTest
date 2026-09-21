using System;
using System.Text.RegularExpressions;

public class Solution
{
    public string solution(string my_string)
    {
        string answer = my_string;
        //return answer.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");
        return Regex.Replace(answer, "[a,e,i,o,u]", "");
    }
}
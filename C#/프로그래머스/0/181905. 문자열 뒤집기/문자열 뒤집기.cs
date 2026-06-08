using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        string target = my_string.Substring(s, e - s + 1);
        string reverse = string.Join("", target.Reverse().ToArray());
        
        return my_string.Replace(target, reverse);
    }
}
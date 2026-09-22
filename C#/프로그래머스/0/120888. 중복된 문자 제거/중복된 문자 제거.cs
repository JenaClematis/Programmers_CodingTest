using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string)
    {
        return String.Join("", my_string.Select(s => s).Distinct());
    }
}
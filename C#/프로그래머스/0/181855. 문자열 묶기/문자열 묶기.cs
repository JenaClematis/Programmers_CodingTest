using System;
using System.Linq;

public class Solution
{
    public int solution(string[] strArr)
    {
        return strArr.GroupBy(str => str.Length).Max(g => g.Count());
    }
}
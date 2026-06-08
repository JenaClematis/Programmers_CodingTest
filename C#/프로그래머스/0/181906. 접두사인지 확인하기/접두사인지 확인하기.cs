using System;

public class Solution
{
    public int solution(string my_string, string is_prefix)
    {
        // IndexOf로도 풀 수 있구나
        return my_string.StartsWith(is_prefix) ? 1 : 0;
    }
}
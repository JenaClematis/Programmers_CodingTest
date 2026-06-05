using System;
using System.Linq;

public class Solution
{
    public int solution(string my_string, string is_suffix)
    {
        string[] str = new string[my_string.Length];
        
        for(int i = 0; i < my_string.Length; i++)
            str[i] = my_string.Substring(i, my_string.Length - i);
        
        return Convert.ToInt32(str.Where(s => s == is_suffix).Any());
    }
}
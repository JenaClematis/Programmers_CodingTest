using System;

public class Solution
{
    public string solution(string my_string, int n)
    {
        //Console.WriteLine(my_string.Length);
        
        return my_string.Substring(my_string.Length - n, n);
    }
}

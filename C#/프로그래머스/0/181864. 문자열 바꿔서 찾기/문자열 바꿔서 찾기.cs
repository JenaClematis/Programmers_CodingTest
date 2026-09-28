using System;

public class Solution
{
    public int solution(string myString, string pat)
    {
        char[] c = myString.ToCharArray();
        
        for(int i = 0; i < c.Length; i++)
        {
            if(c[i] == 'A')
                c[i]++;
            else
                c[i]--;
        }
        
        return Convert.ToInt32(String.Join("", c).Contains(pat));
    }
}
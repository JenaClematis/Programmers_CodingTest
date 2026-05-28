using System;

public class Solution
{
    public int solution(string ineq, string eq, int n, int m)
    {
        /*
        if(ineq.Equals(">") && eq.Equals("="))
            return n >= m ? 1 : 0;
        else if(ineq.Equals(">"))
            return n > m ? 1 : 0;
        else if(eq.Equals("="))
            return n <= m ? 1 : 0;
        else
            return n < m ? 1 : 0;
        */
        
        string s = ineq + eq;
        
        if(s == ">=")
            return n >= m ? 1 : 0;
        else if(s == "<=")
            return n <= m ? 1 : 0;
        else if(s == ">!")
            return n > m ? 1 : 0;
        else
            return n < m ? 1 : 0;
    }
}
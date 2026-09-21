using System;
using System.Text.RegularExpressions;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        
        /*
        for(int i = 0; i < my_string.Length; i++)
            if(Int32.TryParse(my_string[i].ToString(), out int num))
                answer += num;
        */
        
        MatchCollection matches = Regex.Matches(my_string, "[0-9]");
        
        if(matches.Count > 0)
            for(int i = 0; i < matches.Count; i++)
                answer += Convert.ToInt32(matches[i].ToString());
        
        return answer;
    }
}
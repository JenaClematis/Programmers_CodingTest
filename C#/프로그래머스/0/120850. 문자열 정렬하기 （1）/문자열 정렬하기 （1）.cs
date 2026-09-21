using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Solution
{
    public int[] solution(string my_string)
    {
        /*
        List<int> answer = new List<int>();
        
        for(int i = 0; i < my_string.Length; i++)
            if(Int32.TryParse(my_string[i].ToString(), out int num))
                answer.Add(num);
        
        answer.Sort();
        
        return answer.ToArray();
        */
        
        List<int> answer = new List<int>();
        MatchCollection matches = Regex.Matches(my_string, "[0-9]");
        
        if(matches.Count > 0)
        {
            for(int i = 0; i < matches.Count; i++)
                answer.Add(Convert.ToInt32(matches[i].ToString()));
            
            answer.Sort();
        }
        
        return answer.ToArray();
    }
}

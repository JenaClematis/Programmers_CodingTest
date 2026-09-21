using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string my_string)
    {
        List<int> answer = new List<int>();
        
        for(int i = 0; i < my_string.Length; i++)
            if(Int32.TryParse(my_string[i].ToString(), out int num))
                answer.Add(num);
        
        answer.Sort();
        
        return answer.ToArray();
    }
}
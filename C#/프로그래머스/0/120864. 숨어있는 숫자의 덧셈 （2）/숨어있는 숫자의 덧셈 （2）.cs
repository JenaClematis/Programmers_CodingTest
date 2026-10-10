using System;

public class Solution
{
    public int solution(string my_string)
    {
        int answer = 0;
        string str = "";
        
        for(int i = 0; i < my_string.Length; i++)
        {
            if(Int32.TryParse(my_string[i].ToString(), out int num))
                str += num;
            else if(str.Length > 0)
            {
                answer += Int32.Parse(str);
                str = "";
            }
        }
        
        if(str.Length > 0)
            answer += Int32.Parse(str);
        
        return answer;
    }
}
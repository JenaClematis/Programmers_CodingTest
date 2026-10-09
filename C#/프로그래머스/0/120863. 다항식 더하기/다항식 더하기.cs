using System;

public class Solution
{
    public string solution(string polynomial)
    {
        string[] str = polynomial.Split(" ");
        string answer = "";
        int mul = 0, num = 0;
        
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i].Contains("x"))
                mul += str[i].Length > 1 ? Int32.Parse(str[i].Substring(0, str[i].Length - 1)) : 1;
            else if(Int32.TryParse(str[i], out int number))
                num += number;
        }
        
        answer += mul > 1 ? mul + "x" : (mul == 1 ? "x" : "");
        answer += mul > 0 && num > 0 ? " + " + num : (num > 0 ? num.ToString() : "");
        
        return answer;
    }
}
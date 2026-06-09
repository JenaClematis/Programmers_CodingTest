using System;

public class Solution
{
    public string solution(int q, int r, string code)
    {
        string answer = "";
        
        // 아; Linq 공부 열심히 했으면서 Linq 쓸 생각은 왜 안나냐....
        for(int i = 0; i < code.Length; i++)
            answer += i % q == r ? code[i].ToString() : "";
        
        return answer;
    }
}
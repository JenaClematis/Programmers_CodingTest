using System;

public class Solution
{
    public string solution(string rsp)
    {
        // 바위 0 | 가위 2 | 보 5
        string answer = "";
        int num;
        
        for(int i = 0; i < rsp.Length; i++)
        {
            num = Int32.Parse(rsp[i].ToString());
            answer += num > 2 ? "2" : num > 0 ? "0" : "5";
        }
        
        return answer;
    }
}
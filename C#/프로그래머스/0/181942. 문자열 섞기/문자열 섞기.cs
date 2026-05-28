using System;

public class Solution {
    public string solution(string str1, string str2) {
        /*
        char[] c1 = str1.ToCharArray();
        char[] c2 = str2.ToCharArray();
        string answer = "";
        for(int i = 0; i < c1.Length; i++)
        {
            answer += c1[i];
            answer += c2[i];
        }
        return answer;
        */
        string answer = "";
        for(int i = 0; i < str1.Length; i++)
            answer += string.Format("{0}{1}", str1[i], str2[i]);
        return answer;
    }
}
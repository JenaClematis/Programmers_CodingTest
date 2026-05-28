using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        
        for(int i = 0; i < k ; i++)
            answer += string.Join("", my_string);
        
        return answer;
    }
}
using System;

public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string answer = my_string;
        answer = answer.Remove(s, overwrite_string.Length);
        answer = answer.Insert(s, overwrite_string);
        return answer;
    }
}
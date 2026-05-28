using System;

public class Solution {
    public int solution(int a, int b) {
        /*
        int v1 = Int32.Parse(string.Format("{0}{1}", a.ToString(), b.ToString()));
        int v2 = Int32.Parse(string.Format("{1}{0}", a.ToString(), b.ToString()));
        int answer = v1 > v2 ? v1 : v2;
        return answer;
        */
        
        int v1 = Int32.Parse($"{a}{b}");
        int v2 = Int32.Parse($"{b}{a}");
        return Math.Max(v1, v2);
    }
}
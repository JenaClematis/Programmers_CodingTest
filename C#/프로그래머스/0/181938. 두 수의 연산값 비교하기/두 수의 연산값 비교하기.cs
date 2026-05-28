using System;

public class Solution {
    public int solution(int a, int b) {
        int v1 = Int32.Parse($"{a}{b}");
        int v2 = 2 * a * b;
        int answer = v1 >= v2 ? v1 : v2;    // Math.Max()가 이 구조로 되어있어서 Max 함수를 바로 써도 상관없음
        return answer;
    }
}
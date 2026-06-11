using System;

public class Solution
{
    public int solution(int[] numbers, int k)
    {
        /*
        // 0, 2, 4, 6 ...
        // 2 * k -> 최대 index를 벗어나면 Length가 짝수이면 0 | 홀수이면 1
        // Length가 짝수라면 ? (k % (Length / 2) - 1) * 2
        // 홀수라면 ? (k - Length / 2) == k
        
        if(numbers.Length % 2 != 0)
            return numbers[k > numbers.Length / 2 + 1 ?
                           1 + (k - (numbers.Length / 2 + 1) - 1) * 2 : (k - 1) * 2];
        else
            return numbers[k > numbers.Length / 2 ? (k % (numbers.Length / 2) - 1) * 2 : (k - 1) * 2];
        */
        
        // AI 힌트로 알아낸 원형으로 연속된 N == % 연산
        // 나머지는 등차수열의 N번째 구하는 공식이면 될 것 같아서 네이버 검색했었음
        return numbers[((k - 1) * 2) % numbers.Length];
    }
}
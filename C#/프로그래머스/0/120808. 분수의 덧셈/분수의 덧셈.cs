using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        // 최소공배수 = a * b / 최대공약수
        int[] answer = new int[2];
        int div = GCD(Math.Max(denom1, denom2), Math.Min(denom1, denom2));
        
        answer[0] = (numer1 * denom2 + numer2 * denom1) / div;
        answer[1] = (denom1 * denom2) / div;
        
        div = GCD(Math.Max(answer[0], answer[1]), Math.Min(answer[0], answer[1]));
        answer[0] /= div;
        answer[1] /= div;
        
        return answer;
    }
    
    private int GCD(int a, int b)
    {
        int temp;
        
        while(b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
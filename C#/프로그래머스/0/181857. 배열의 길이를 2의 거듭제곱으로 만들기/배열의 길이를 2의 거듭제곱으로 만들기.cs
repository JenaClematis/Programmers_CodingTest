using System;

public class Solution
{
    public int[] solution(int[] arr)
    {
        int[] answer;
        int size = arr.Length;
        
        while(true)
        {
            if(IsTwoPow(size))
            {
                answer = new int[size];
                Array.Copy(arr, answer, arr.Length);
                break;
            }
            
            size++;
        }
        
        return answer;
    }
    
    // 2의 거듭제곱 : 비트 연산을 이용하여 검사 가능
    private bool IsTwoPow(int num) => num > 0 && (num & (num - 1)) == 0;
}
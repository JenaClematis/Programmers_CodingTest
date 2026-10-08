using System;

public class Solution
{
    public int solution(int[] array)
    {
        int answer = 0;
        string str = "";
        
        for(int i = 0; i < array.Length; i++)
            str += array[i];
        
        for(int i = 0; i < str.Length; i++)
            answer += str[i] == '7' ? 1 : 0;
        
        return answer;
    }
}
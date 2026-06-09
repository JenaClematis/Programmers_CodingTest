using System;
using System.Linq;

public class Solution
{
    public int[] solution(int[] emergency)
    {
        int[] answer = new int[emergency.Length];
        int index = 0;
        
        foreach(int num in emergency.OrderByDescending(e => e))
            answer[Array.FindIndex(emergency, 0, val => val == num)] = ++index;
        
        return answer;
    }
}
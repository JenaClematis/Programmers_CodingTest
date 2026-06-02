using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] arr)
    {
        // arr[0] 추가    |   stk[length] < arr[i] -> stk[length + 1] = arr[i]
        //               | stk[length] >= arr[i] -> Remove(stk[length])
        List<int> stk = new List<int>();
        int index = 0;
        
        while(index < arr.Length)
        {
            if(stk.Count == 0 || stk[stk.Count - 1] < arr[index])
                stk.Add(arr[index++]);
            else
                stk.RemoveAt(stk.Count - 1);
        }
        
        return stk.ToArray();
    }
}
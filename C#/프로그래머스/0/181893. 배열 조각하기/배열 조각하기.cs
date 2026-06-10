using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr, int[] query)
    {
        List<int> answer = arr.ToList();
        int index, length;
        
        for(int i = 0; i < query.Length; i++)
        {
            index = i % 2 == 0 ? query[i] + 1 : 0;
            length = i % 2 == 0 ? answer.Count - query[i] - 1 : query[i];
            answer.RemoveRange(index, length);
        }
        
        return answer.ToArray();
    }
}
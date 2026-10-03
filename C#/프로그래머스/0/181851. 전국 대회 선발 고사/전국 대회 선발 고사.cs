using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] rank, bool[] attendance)
    {
        List<int> students = new List<int>();
        
        for(int i = 0; i < rank.Length; i++)
            if(attendance[i])
                students.Add(rank[i]);
        
        students.Sort();
        
        for(int i = 0; i < 3; i++)
            students[i] = Array.IndexOf(rank, students[i], 0);
        
        return 10000 * students[0] + 100 * students[1] + students[2];
    }
}
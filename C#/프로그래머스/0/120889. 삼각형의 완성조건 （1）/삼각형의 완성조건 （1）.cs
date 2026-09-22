using System;
using System.Linq;

public class Solution
{
    public int solution(int[] sides)
    {
        int max = 0;
        
        max = sides.Max();
        
        return sides.Sum(s => s) - max > max ? 1 : 2;
    }
}
using System;

public class Solution
{
    public int[] solution(int n, int[] slicer, int[] num_list)
    {
        int a = slicer[0], b = slicer[1], c = slicer[2], index = 0;
        int size = n > 3 ? ((b - a) / c) + 1: n > 2 ? b - a + 1 : n > 1 ? num_list.Length - a : b + 1;
        int[] answer = new int[size];
        
        switch(n)
        {
            case 1:
                Array.Copy(num_list, 0, answer, 0, answer.Length);
                break;
            case 2:
            case 3:
                Array.Copy(num_list, a, answer, 0, answer.Length);
                break;
            case 4:
                for(int i = a; i <= b; i += c)
                    answer[index++] = num_list[i];
                break;
        }
            
        return answer;
    }
}
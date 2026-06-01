using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        // num_list[Length - 1] > num_list[Length - 2] -> num_list[Length - 1] - num_list[Length - 2]
        // num_list[Length - 1] < num_list[Length - 2] -> num_list[Length - 1] * 2
        int[] answer = new int[num_list.Length + 1];
        Array.Copy(num_list, answer, num_list.Length);
        answer[num_list.Length] = num_list[num_list.Length - 1] > num_list[num_list.Length - 2] ?
                                    num_list[num_list.Length - 1] - num_list[num_list.Length - 2] :
                                    num_list[num_list.Length - 1] * 2;
        return answer;
    }
}
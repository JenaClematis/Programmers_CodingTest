using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        // num_list[Length - 1] > num_list[Length - 2] -> num_list[Length - 1] - num_list[Length - 2]
        // num_list[Length - 1] < num_list[Length - 2] -> num_list[Length - 1] * 2
        int length = num_list.Length;
        int[] answer = new int[length + 1];
        Array.Copy(num_list, answer, length);
        answer[length] = num_list[length - 1] > num_list[length - 2] ?
                            num_list[length - 1] - num_list[length - 2] : num_list[length - 1] * 2;
        return answer;
    }
}
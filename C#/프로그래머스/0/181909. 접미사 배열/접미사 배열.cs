using System;
using System.Linq;

public class Solution
{
    public string[] solution(string my_string)
    {
        /*
        for(int i = 0; i < my_string.Length; i++)
            Console.Write($"{my_string[i]} = {Convert.ToInt32(my_string[i])} ");
        Console.WriteLine();
        */
        
        // char의 int로 사전 순으로 정렬하면 될 듯
        string[] answer = new string[my_string.Length];
        
        for(int i = 0; i < my_string.Length; i++)
            answer[i] = my_string.Substring(i, my_string.Length - i);
       
        return answer.OrderBy(a => a).ToArray();
    }
}
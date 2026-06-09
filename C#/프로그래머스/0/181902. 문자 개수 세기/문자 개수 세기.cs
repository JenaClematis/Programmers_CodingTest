using System;

public class Solution
{
    public int[] solution(string my_string)
    {
        /*
        for(int i = 0; i < my_string.Length; i++)
            Console.Write(Convert.ToInt32(my_string[i]) + " ");
        Console.WriteLine();
        */
        
        int[] answer = new int[52];
        int index;
        
        for(int i = 0; i < my_string.Length; i++)
        {
            index = Convert.ToInt32(my_string[i]) % 65 + (char.IsUpper(my_string[i]) ? 0 : -6);
            answer[index]++;
        }
        
        return answer;
    }
}
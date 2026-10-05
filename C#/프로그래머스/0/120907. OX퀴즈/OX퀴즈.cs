using System;

public class Solution
{
    public string[] solution(string[] quiz)
    {
        string[] str = new string[5], answer = new string[quiz.Length];
        int[] num = new int[3];
        int number = 0;
        
        for(int i = 0; i < quiz.Length; i++)
        {
            str = quiz[i].Split(" ");
            
            for(int j = 0; j < 3; j++)
                num[j] = Int32.Parse(str[2 * j]);
            
            number = str[1] == "+" ? num[0] + num[1] : num[0] - num[1];
            answer[i] = number == num[2] ? "O" : "X";
        }
        
        return answer;
    }
}
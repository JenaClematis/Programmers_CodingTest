using System;

public class Solution
{
    public string[] solution(string[] picture, int k)
    {
        string[] answer = new string[picture.Length * k];
        string str = "";
        
        for(int i = 0; i < picture.Length; i++)
        {
            str = "";
            
            for(int j = 0; j < picture[i].Length; j++)
                str += new string(picture[i][j], k);
            
            for(int j = 0; j < k; j++)
                answer[k * i + j] = str;
        }
        
        return answer;
    }
}
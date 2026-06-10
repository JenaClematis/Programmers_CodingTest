using System;

public class Solution
{
    public string solution(string letter)
    {
        string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..",
                          "--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-",
                          "-.--","--.."};
        string[] letters = letter.Split(' ');
        string answer = "";
        
        foreach(string str in letters)
        {
            for(int i = 0; i < morse.Length; i++)
                if(morse[i].Equals(str))
                    answer += Convert.ToChar(i + 97);
        }
        
        return answer;
    }
}
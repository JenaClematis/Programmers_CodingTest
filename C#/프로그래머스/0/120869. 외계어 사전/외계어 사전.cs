using System;

public class Solution
{
    public int solution(string[] spell, string[] dic)
    {
        for(int i = 0; i < dic.Length; i++)
        {
            if(dic[i].Length != spell.Length)
                continue;
            
            for(int j = 0; j < spell.Length; j++)
            {
                if(!dic[i].Contains(spell[j]))
                    break;
                
                if(j == spell.Length - 1)
                    return 1;
            }
        }
        
        return 2;
    }
}
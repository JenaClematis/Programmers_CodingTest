using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int a, int b, int c, int d)
    {
        int score = 0;
        int[] dices = { a, b, c, d };
        Dictionary<int, int> pattern = new Dictionary<int, int>();
        
        for(int i = 0; i < dices.Length; i++)
        {
            if(!pattern.ContainsKey(dices[i]))
                pattern.Add(dices[i], 1);
            else
                pattern[dices[i]]++;
        }
        
        int p, q, r, total;
        p = q = r = total = 0;
        int min = int.MaxValue;
        
        switch(pattern.Count)
        {
            case 1:
                foreach(int key in pattern.Keys)
                {
                    score = 1111 * key;
                    break;
                }
                break;
            case 2:
                foreach(int key in pattern.Keys)
                {
                    if(pattern[key] == 2)
                    {
                        if(p == 0)
                            p = key;
                        else if(p != key)
                        {
                            score = (p + key) * Math.Abs(p - key);
                            break;
                        }
                    }
                    else
                    {
                        if(pattern[key] == 3)
                        {
                            if(q == 0)
                                p = key;
                            else
                            {
                                score = (10 * key + q) * (10 * key + q);
                                break;
                            }
                        }
                        else
                        {
                            if(p == 0)
                                q = key;
                            else
                            {
                                score = (10 * p + key) * (10 * p + key);
                                break;
                            }
                        }
                    }
                }
                break;
            case 3:
                foreach(int key in pattern.Keys)
                    if(pattern[key] == 1)
                    {
                        if(q == 0)
                            q = key;
                        else
                        {
                            score = q * key;
                            break;
                        }
                    }
                break;
            case 4:
                foreach(int key in pattern.Keys)
                    min = Math.Min(min, key);
                
                score = min;
                break;
        }
        
        return score;
    }
}
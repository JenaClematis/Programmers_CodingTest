using System;

public class Solution
{
    public int solution(int price)
    {
        // 10만원 이상 -> 5% | 30만원 이상 -> 10% | 50만원 이상 -> 20%
        /*
        float sale = price;
        
        if(price >= 500000)
            sale *= 0.2f;
        else if(price >= 300000)
            sale *= 0.1f;
        else if(price >= 100000)
            sale *= 0.05f;
        else
            sale = 0f;
        
        return (int)MathF.Floor(price - sale);
        */
        
        return price >= 500000 ? (int)(price * 0.8f) :
               price >= 300000 ? (int)(price * 0.9f) :
               price >= 100000 ? (int)(price * 0.95f) : price;
    }
}
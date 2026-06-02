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

        // 삼항연산자가 너무 많아서 별로인 것 같아서 조건문으로 바꿨는데 그게 오히려 더 길었네...ㅎ
        return price >= 500000 ? (int)(price * 0.8f) :
               price >= 300000 ? (int)(price * 0.9f) :
               price >= 100000 ? (int)(price * 0.95f) : price;
    }
}

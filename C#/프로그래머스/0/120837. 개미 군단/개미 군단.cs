using System;

public class Solution
{
    public int solution(int hp)
    {
        int curHp = hp;
        int answer = 0;
        
        while(curHp > 0)
        {
            answer += curHp / 5 > 0 ? curHp / 5 : curHp / 3 > 0 ? curHp / 3 : curHp / 1;
            curHp = curHp / 5 > 0 ? curHp % 5 : curHp / 3 > 0 ? curHp % 3 : 0;
        }
        
        return answer;
    }
}
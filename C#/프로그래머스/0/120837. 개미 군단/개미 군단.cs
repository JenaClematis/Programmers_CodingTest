using System;

public class Solution
{
    public int solution(int hp)
    {
        int curHp = hp;
        int answer = 0;
        
        // 아 맞네; 그냥 각각의 개미의 수를 구했어도 되네... 왜 한꺼번에 구하려고 했지...
        while(curHp > 0)
        {
            answer += curHp / 5 > 0 ? curHp / 5 : curHp / 3 > 0 ? curHp / 3 : curHp / 1;
            curHp = curHp / 5 > 0 ? curHp % 5 : curHp / 3 > 0 ? curHp % 3 : 0;
        }
        
        return answer;
    }
}
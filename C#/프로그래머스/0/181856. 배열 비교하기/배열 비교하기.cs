using System;

public class Solution
{
    public int solution(int[] arr1, int[] arr2)
    {
        int answer = 0, size1 = arr1.Length, size2 = arr2.Length;
        int opp1 = 0, opp2 = 0;
        
        for(int i = 0; i < size1; i++)
            opp1 += arr1[i];
        
        for(int i = 0; i < size2; i++)
            opp2 += arr2[i];
        
        if(size2 == size1)
            answer = opp2 > opp1 ? -1 : (opp2 == opp1 ? 0 : 1);
        else if(size2 > size1)
            answer = -1;
        else if(size1 > size2)
            answer = 1;
        
        return answer;
    }
}
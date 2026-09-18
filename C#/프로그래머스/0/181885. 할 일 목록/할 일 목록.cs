using System;

public class Solution
{
    public string[] solution(string[] todo_list, bool[] finished)
    {
        int length = 0;
        
        for(int i = 0; i < finished.Length; i++)
            length += !finished[i] ? 1 : 0;
        
        string[] answer = new string[length];
        int index = 0;
        
        for(int i = 0; i < finished.Length; i++)
        {
            if(finished[i])
                continue;
            
            answer[index++] = todo_list[i];
            
            if(index >= length)
                break;
        }
        
        return answer;
    }
}
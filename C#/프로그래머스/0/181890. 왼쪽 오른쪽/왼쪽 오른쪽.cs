using System;

public class Solution
{
    public string[] solution(string[] str_list)
    {
        // l VS r -> l : 왼쪽에 있는 문자열들 | r : 오른쪽에 있는 문자열들 | 없으면 : Empty
        int index = Array.FindIndex(str_list, 0, val => val == "l" || val == "r");
        
        if(index == -1)
            return Array.Empty<string>();
        
        string[] answer = new string[str_list[index] == "l" ? index : str_list.Length - index - 1];
        
        if(str_list[index] == "l")
            Array.Copy(str_list, 0, answer, 0, index);
        else
            Array.Copy(str_list, index + 1, answer, 0, answer.Length);
        
        return answer;
    }
}
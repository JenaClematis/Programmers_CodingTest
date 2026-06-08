using System;
using System.Linq;

public class Solution
{
    public string solution(string my_string, int s, int e)
    {
        // 그렇네, my_string을 char[]로 바꾼 다음에 그냥 해당 글자를 reverse하고 string으로 바꿀 생각을 못했지..?
        string target = my_string.Substring(s, e - s + 1);
        string reverse = string.Join("", target.Reverse().ToArray());
        
        return my_string.Replace(target, reverse);
    }
}
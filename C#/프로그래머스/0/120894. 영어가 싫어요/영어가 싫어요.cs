using System;

public class Solution
{
    public long solution(string numbers)
    {
        string str = numbers.Replace("zero", "0")
                            .Replace("one", "1").Replace("two", "2").Replace("three", "3")
                            .Replace("four", "4").Replace("five", "5").Replace("six", "6")
                            .Replace("seven", "7").Replace("eight", "8").Replace("nine", "9");
        
        long answer = Int64.Parse(str);
        return answer;
    }
}
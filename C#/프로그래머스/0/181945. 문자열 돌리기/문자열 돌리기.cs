using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        char[] c1 = s.ToCharArray();
        
        foreach(var c in c1)
            Console.WriteLine(c);
    }
}
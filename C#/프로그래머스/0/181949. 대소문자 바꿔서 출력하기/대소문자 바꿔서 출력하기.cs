using System;

public class Example
{
    public static void Main()
    {
        String s;
        //char[] c;

        Console.Clear();
        s = Console.ReadLine();
        //c = s.ToCharArray();
        
        //for(int i = 0; i < c.Length; i++)
        for(int i = 0; i < s.Length; i++)
        {
            //if(Char.IsLower(c[i]))
                //Console.Write(Char.ToUpper(c[i]));
            //else
                //Console.Write(Char.ToLower(c[i]));
            if(Char.IsLower(s, i))
                Console.Write(Char.ToUpper(s[i]));
            else
                Console.Write(Char.ToLower(s[i]));
        }
    }
}

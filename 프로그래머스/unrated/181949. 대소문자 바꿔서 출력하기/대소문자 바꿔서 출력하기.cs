using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();

        var reverse = s.Select(c => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c));        
        
        Console.Write(string.Join("",reverse));
    }
}
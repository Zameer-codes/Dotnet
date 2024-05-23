using System;

public class ConsoleClass
{
    static public void Main()
    {
        Console.WriteLine("Background color  :{0}", Console.BackgroundColor);

        Console.WriteLine("Foreground color : {0}", Console.ForegroundColor);
        Console.Write("Please Enter a Key : ");
        Console.ReadKey();
        Console.Clear();
        Console.Beep();
        Console.Read();
        Console.WriteLine(Console.Error);
    }
}
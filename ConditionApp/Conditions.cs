using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace ConditionApp;

public class Conditions
{
    public void Run()
    {
        Console.WriteLine("Name a color ");
        string color = Console.ReadLine();



        ConsoleColor consoleColor = ConsoleColor.White;
        try
        {
            consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color, true);
        }
        catch (Exception)
        {
            //Invalid color
        }

        Console.WriteLine("Name one more ");
        string bColor = Console.ReadLine();

        ConsoleColor consoleColorB = ConsoleColor.Black;
        try
        {
            consoleColorB = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), bColor, true);
        }
        catch (Exception)
        {
            //Invalid color
        }

        Console.ForegroundColor = consoleColor;
        Console.BackgroundColor = consoleColorB;

        Console.Clear();

        Console.WriteLine("Zadejte první:");
        string first = Console.ReadLine();

        Console.WriteLine("Zadejte druhé:");
        string second = Console.ReadLine();

        Console.WriteLine("Zadejte treti:");
        string third = Console.ReadLine();

        Console.WriteLine("Zadejte ctvrte:");
        string fourth = Console.ReadLine();

        string res1 = GetResult(first, second);

        string res2 = GetResult(third, fourth);

        string res3 = GetResult(res1, res2);

        Console.WriteLine(res3);
    }

    public string Process(string a, string b)
    {
        return a.ToUpper() + b.ToLower();
    }

    public void PrintDelimiter()
    {
        Console.WriteLine("####");
    }

    public string GetResult(string x, string y)
    {
        if (x.Length > y.Length)
        {
            return Process(x, y);
        }
        else
        {
            return Process(y, x);
        }
    }
    public string FirstLetterToUpper(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToUpper(str[0]) + str.Substring(1);

        return str.ToUpper();
    }
}
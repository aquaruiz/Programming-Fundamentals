using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        var input1 = Console.ReadLine();

        var numberOfStrings = 0;
        var delimiter = string.Empty;

        try
        {
            numberOfStrings = int.Parse(input1);
        }
        catch
        {
            delimiter = input1;
            numberOfStrings = int.Parse(Console.ReadLine());
        }

        var result = string.Empty;
        var currentString = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            currentString = Console.ReadLine();
            result += currentString + delimiter;
        }

        if (delimiter != string.Empty)
        {
            Console.WriteLine(result.Remove(result.Length - delimiter.Length));
        }
        else
        {
            Console.WriteLine(result);
        }
    }
}
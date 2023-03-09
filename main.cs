using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program {
    public static void Main (string[] args) {
        var lines = ReadInput("Input.txt");
        var nums = lines.Select(ToDecimalNum);
        var sum = nums.Sum();

        Console.WriteLine ($"Sum = {sum}");
    }

    static long ToDecimalNum(string text)
    {
        var ints = text.Select(ToInt);
        return ints.Sum(); // ###################        
    }

    static IEnumerable<string> ReadInput(string file) =>
        File.ReadLines(file);

    static int ToInt(char c)
    {
        return c switch
        {
            '2' => 2,
            '1' => 1,
            '0' => 0,
            '-' => -1,
            '=' => -2,
            _ => throw new NotSupportedException()
        };        
    }
}
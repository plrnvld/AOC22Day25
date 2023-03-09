using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        var lines = ReadInput("Input.txt");
        var nums = lines.Select(ToNormalNum);


        foreach (var num in nums)
            Console.WriteLine($"> {num}");

        var sum = nums.Sum();

        Console.WriteLine($"Sum={sum}");

        Console.WriteLine($"SNAFU={ToSnafu(sum)}");
    }

    static long ToNormalNum(string text)
    {
        var ints = text.Select(ToInt);
        var reversed = ints.Reverse().ToList();

        var result = 0L;
        var baseNum = 1L;
        for (var i = 0; i < reversed.Count; i++)
        {
            result += reversed[i] * baseNum;
            baseNum *= 5;
        }

        return result;
    }

    static IEnumerable<string> ReadInput(string file) =>
        File.ReadLines(file);

    static int ToInt(char c) =>    
        c switch
        {
            '2' => 2,
            '1' => 1,
            '0' => 0,
            '-' => -1,
            '=' => -2,
            _ => throw new NotSupportedException()
        };

    static string ToSnafu(long num)
    {
        return "hi";
    }
}

// normal sum = 36067808580527
// 36_067_808_580_527

// I found the Snafu number using Excel 😁
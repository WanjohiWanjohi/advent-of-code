using System;
using System.Net;
using System.IO;
using AdventOfCode;

class Day1: InputClass
{
    public string resourceUrl { get; set; }
        //= "https://adventofcode.com/2021/day/1/input";
    public Day1(string ResourceURL) :base()
    {
        resourceUrl = ResourceURL;
    }
    public void Day1Challenge(string [] InputItems)
    {
        int array_length = InputItems.Length;
        List<int> differencesList = new List<int>();
        for (int i = 0; i < array_length - 1; i++)
        {
            try
            {
                int minuend = Int32.Parse(InputItems[i + 1]);
                int subtrahend = Int32.Parse(InputItems[i]);
                int diff = minuend - subtrahend;
                differencesList.Add(diff);
                var positive_depths = differencesList.Where(x => x > 0).Count();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            

        }

    }
}

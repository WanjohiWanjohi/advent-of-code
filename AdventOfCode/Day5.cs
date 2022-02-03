using System;
using System.Net;
using System.IO;
using AdventOfCode;

public class Day4 : InputClass   
{
    // bingo subsystem : automatically generates a random order in which to draw numbers and a random set of boards


    public string resourceUrl { get; set; }


    public Day4(string ResourceURL) : base()
    {
        resourceUrl = ResourceURL;
    }

    public string[] Day4Challenge(string ResourceUrl)
    {
        HttpClient httpClient =base.CreateHttpClient();
        Task<string[]> urlContent = base.GetContentAsync(ResourceUrl, httpClient);
        return urlContent.Result;

    }

    public IEnumerable<string> StringsToDraw(string[] inputString)
    {
        var inputArray = inputString.ToArray();
        var bingoNumbers = new ArraySegment<string>(inputArray, 0, 1);
        List<string> drawList = bingoNumbers[0].ToString().Split(",").ToList();
        return drawList;
    }

   

}



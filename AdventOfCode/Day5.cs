using System;
using System.Net;
using System.IO;
using AdventOfCode;

public class Day5 : InputClass   
{

    public override string resourceUrl { get; set; }


    public Day5(string ResourceURL) : base()
    {
        resourceUrl = ResourceURL;
    }

    public string[] Day5Challenge()
    {
        HttpClient httpClient =base.CreateHttpClient();
        Task<string[]> urlContent = base.GetContentAsync( httpClient);
        return urlContent.Result;

    }
    internal Dictionary<string, int> GetSegment(string s, int segmentNumber)
    {
        Dictionary<string, int> Segment = new Dictionary<string, int>();
        string[] xAndY;
        if (segmentNumber == 1)
        {
            xAndY = s.Split("->")[0].Split(",");

        }
        else if (segmentNumber == 2)
        {
            xAndY = s.Split("->")[1].Split(",");

        }
        else
        {
            return default;
        }

        Segment.Add("x", Convert.ToInt32(xAndY[0]));
        Segment.Add("y", Convert.ToInt32(xAndY[1]));
        return Segment;

    }





}



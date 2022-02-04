using System;
using System.Net;
using System.IO;
using AdventOfCode;

public class Day3 : InputClass   
{
  
    public override string resourceUrl { get; set; }


    public Day3(string ResourceURL) : base()
    {
        resourceUrl = ResourceURL;
    }

    public string[] Day3Challenge(string ResourceUrl)
    {
         HttpClient httpClient =base.CreateHttpClient();
        httpClient.BaseAddress = new Uri(resourceUrl);
        Task<string[]> urlContent = base.GetContentAsync( httpClient);
        return urlContent.Result;

    }

    public IEnumerable<string> TransformInput(string[] content , int startIndex , int endIndex)
    {
        List<string> verticalItems = new List<string>();
        foreach (string item in content)
        {
            if (item.Length > 0)
            {
                var newItem = (string)item.Substring(startIndex, endIndex);
                verticalItems.Add(newItem);
            }
        }
        return verticalItems;
    }
    public string GetMostCommon(IEnumerable<string> positionArray)
    {
            var most = positionArray.GroupBy(k => k).OrderByDescending(grp => grp.Count())
              .Select(grp => grp.Key).First();
           
        return most;
    }
    public string GetLeastCommon(IEnumerable<string> positionArray)
    {
        var least = positionArray.GroupBy(i => i).OrderByDescending(grp => grp.Count())
          .Select(grp => grp.Key).Last();
        return least;
    }
    public string[] GetGammaAndEpsilon(string [] content)
    {
        List<string> maxValue = new();
        List<string> minValue = new();
        for (int i = 0; i < 12; i++)
        {
            var positionArray = TransformInput(content, i, 1);
            var maxValueAtPosition = GetMostCommon(positionArray);
            var minValueatPosition = GetLeastCommon(positionArray);
            maxValue.Add(maxValueAtPosition);
            minValue.Add(minValueatPosition);
        }
        string maxString = string.Join("", maxValue.ToArray());
        string minString = string.Join("", minValue.ToArray());
        string[] binaryOutput = { maxString, minString };
        return binaryOutput;

    }
    public string [] GetOygenGeneratorRating(string[] OxygenGeneratorRating)
    {
        foreach(var item in OxygenGeneratorRating.ToList())
        {
            //remove this constant in the range
            foreach (var i in Enumerable.Range(0, item.Length+1))
            {
                var maxAndMin = GetGammaAndEpsilon(OxygenGeneratorRating);

                if (OxygenGeneratorRating.Length > 1)
                {
                    var mostFrequentString = maxAndMin[0];
                    var newList = OxygenGeneratorRating.Where(x => x != "")
                                         .Where(x => x[i] == mostFrequentString[i] || x[i] == 1).ToArray();
                    OxygenGeneratorRating = newList;
                }
            }
        }
        
        return OxygenGeneratorRating;

    }
    public string[] CO2ScrubberRating(string[] CO2ScrubberRating)
    {
        foreach (var item in CO2ScrubberRating.ToList())
        {
            foreach (var i in Enumerable.Range(0, item.Length+1))
            {
                var maxAndMin2 = GetGammaAndEpsilon(CO2ScrubberRating);

                if (CO2ScrubberRating.Length > 1)
                {
                    var leastFrequentString = maxAndMin2[1];
                    var anotherNewList = CO2ScrubberRating.Where(x => x != "")
                                            .Where(x => x[i] == leastFrequentString[i] || x[i] == 1).ToArray();
                    CO2ScrubberRating = anotherNewList;
                }
            }

        }
        return CO2ScrubberRating;

    }


}



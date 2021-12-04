using System;
using System.Net;
using System.IO;
using AdventOfCode;

public class Day3 : InputClass   
{
  
    public string resourceUrl { get; set; }


    public Day3(string ResourceURL) : base()
    {
        resourceUrl = ResourceURL;
    }

    public string[] Day3Challenge(string ResourceUrl)
    {
         HttpClient httpClient =base.CreateHttpClient();
        httpClient.BaseAddress = new Uri(resourceUrl);
        Task<string[]> urlContent = base.GetContentAsync(ResourceUrl, httpClient);
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
    public void GetMostandLeastCommon(IEnumerable<string> positionArray)
    {
            var most = positionArray.GroupBy(k => k).OrderByDescending(grp => grp.Count())
              .Select(grp => grp.Key).First();
            var least  = positionArray.GroupBy(i => i).OrderByDescending(grp => grp.Count())
              .Select(grp => grp.Key).Last();
       
    }
}



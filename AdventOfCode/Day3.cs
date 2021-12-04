﻿using System;
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
    public string[] GetGammanEpsilon(string [] content)
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
        //convert this to a key value pair maybe 
        return binaryOutput;

    }


}



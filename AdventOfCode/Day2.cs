using System;
using System.Net;
using System.IO;
using AdventOfCode;

public class Day2 : InputClass   
    
{
  
    public string resourceUrl { get; set; }


    public Day2(string ResourceURL) : base()
    {
        resourceUrl = ResourceURL;
    }

    public string[] Day2Challenge(string ResourceUrl)
    {
         HttpClient httpClient =base.CreateHttpClient();
        httpClient.BaseAddress = new Uri(resourceUrl);
        Task<string[]> urlContent = base.GetContentAsync(ResourceUrl, httpClient);
        return urlContent.Result;

    }
   
    
    public int[] ChallengeSolution(List<KeyValuePair<string, string>> keyValuePairs)
    {
        int horizontal = 0;
        int vertical = 0;
        int aim = 0;
        foreach (var KeyPair in keyValuePairs)
        {
            if (KeyPair.Key == "forward")
            {
                var Value = Int32.Parse(KeyPair.Value);
                horizontal += Value;
                var DepthIncrease = aim * Value;
                vertical += DepthIncrease;

            }
            else if (KeyPair.Key == "down")
            {
                //vertical += int.Parse(KeyPair.Value);
                aim +=int.Parse(KeyPair.Value);
            }
            else if (KeyPair.Key == "up")
            {
                //vertical -= int.Parse(KeyPair.Value);
                aim -=int.Parse(KeyPair.Value);
            }

        }
        int[] myPosition = { horizontal ,vertical };
        return myPosition;
    }
    public List<KeyValuePair<string, string>> SerializeintoKeyValue(string[] content)
    {
        var KeyPairs = new List<KeyValuePair<string, string>>();
        foreach (string number in content)
        {
            string[] value = number.Split(' ');
            if (value.Length > 1)
            {
                KeyValuePair<string, string> myKeyValuePair = new KeyValuePair<string, string>(value[0], value[1]);
                KeyPairs.Add(myKeyValuePair);
            }
        }
        return KeyPairs;
    }
    public int MultiplyPosition(int[] solution)
    {
        int prod = 1;
        foreach (int value in solution)
        {
            prod *= value;
        }
        return prod;
    }

}



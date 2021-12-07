using System;
using System.Net;
using System.IO;
using AdventOfCode;
using System.Collections;
using Newtonsoft.Json;
using System.Linq;

//Day 2 Challenge: Part 1
//

/*string Day2Url =  "https://adventofcode.com/2021/day/2/input";
Day2 day2 = new Day2(Day2Url);
var content = day2.Day2Challenge(Day2Url);
var KeyPairs = day2.SerializeintoKeyValue(content);
var solutionList = day2.ChallengeSolution(KeyPairs);
var answer = day2.MultiplyPosition(solutionList);
Console.WriteLine(answer);*/

// Day 3 Challenge

string Day3Url = "https://adventofcode.com/2021/day/3/input";
Day3 day3 = new Day3(Day3Url);
var content = day3.Day3Challenge(Day3Url);
string[] gammaAndEpsilpon = day3.GetGammaAndEpsilon(content);
var gamma = Convert.ToInt32(gammaAndEpsilpon[0] , 2);
var gammaByte = gammaAndEpsilpon[0];
var epsilonByte = gammaAndEpsilpon[1];
var epsilon = Convert.ToInt32(gammaAndEpsilpon[1] , 2);
var powerConsumption = gamma * epsilon;
List<string> CO2Array = new ();
List <string> O2Array = new();
foreach (var contentString in content)
{
    if(contentString != "")
    {
        char firstCharacter = contentString[0];
        char epsilonBit = epsilonByte[0];
        char gammaBit = gammaByte[0];
        Console.WriteLine(gammaBit);
        if (firstCharacter.Equals(gammaBit))
        {
            O2Array.Add(contentString);
        }
        else if (firstCharacter.Equals( epsilonBit))
        {
            CO2Array.Add(contentString);

        }
    }
}

foreach (var contentString in O2Array)
{
    for (int i = 0; i < 12; i++)
    {
        var positionArray = day3.TransformInput(O2Array.ToArray(), i, 1);
        var maxValueAtPosition = day3.GetMostCommon(positionArray);
        var minValueatPosition = day3.GetLeastCommon(positionArray);
    }
     


}
Console.WriteLine(O2Array);





using System;
using System.Net;
using System.IO;
using AdventOfCode;
using System.Collections;
using Newtonsoft.Json;

//Day 2 Challenge
string Day2Url =  "https://adventofcode.com/2021/day/2/input";
Day2 day2 = new Day2(Day2Url);
var content = day2.Day2Challenge(Day2Url);
var KeyPairs = new List<KeyValuePair<string,string>>();
foreach (string number in content)
{
    string[]  value = number.Split(' ');
    if (value.Length >1)
    {
        KeyValuePair<string, string> myKeyValuePair = new KeyValuePair<string, string>(value[0], value[1]);
        KeyPairs.Add(myKeyValuePair);
    } 
}
var solutionList = day2.ChallengeSolution(KeyPairs);
var answer = day2.MultiplyPosition(solutionList);


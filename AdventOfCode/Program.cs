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

var OxygenGeneratorRating = content;
var CO2ScrubberRating = content;

var OxygenRating = Convert.ToInt32( day3.GetOygenGeneratorRating(OxygenGeneratorRating)[0] , 2);
int CO2Rating = Convert.ToInt32(day3.CO2ScrubberRating(CO2ScrubberRating)[0] , 2);
int lifesupportRating = CO2Rating * OxygenRating;
Console.WriteLine(lifesupportRating);






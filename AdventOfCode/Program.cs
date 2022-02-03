










string Day4Url = "https://adventofcode.com/2021/day/4/input";













/*
string Day4Url = "https://adventofcode.com/2021/day/4/input";
Day4 day4 = new Day4(Day4Url);
var inputString = day4.Day4Challenge(Day4Url).ToArray();
var stringsToDraw = day4.StringsToDraw(inputString);
var bingoBoards = inputString.Skip(1).ToList();

var bingoBoardValues = bingoBoards.GroupBy(x => x.Length <= 1)
                                                .Where(x => x.Key == false)
                                                .SelectMany(x => x);

var copiedBingoBoards = new List<string[]>();
for (int iteration = 1 ; iteration <stringsToDraw.Count() ; iteration++) {
    var bingoLine = BingoLine(stringsToDraw, iteration);

    for (int i = 0; i < bingoBoardValues.Count(); i += 5)
    {
        for (int j = 0; j < 4; i++)
        {
            var currentBingoLine = bingoBoardValues.ElementAt(i + j).Split(" ");
            var currentIntersection = currentBingoLine.Intersect(bingoLine);
            if (currentIntersection.Count() == 0)
            {
                var cleanedBingoLine = currentBingoLine.Where(x => !x.Equals("")).ToArray();
                copiedBingoBoards.Add(cleanedBingoLine);


                continue;
            }
            else
            {
                foreach (var intersection in currentIntersection)
                {
                    var indexInCurrentBingoLine = Array.FindIndex(currentBingoLine , s=>s.Equals(intersection));
                    currentBingoLine[indexInCurrentBingoLine] = "x";
                    var cleanedBingoLine = currentBingoLine.Where(x => !x.Equals("")).ToArray();
                    copiedBingoBoards.Add(cleanedBingoLine);
                }
            }
        }
        // TODO: Look along columns also : this only looks across rows 
    }

}
*/

/// <summary>
///  // if its the first iteration , then take the first 6 values , else 
/// skip the first 6(n-1)values
/// always take 6
/// </summary>
string[] BingoLine(IEnumerable<string> stringsToDraw, int Iteration)
{
    if (Iteration == 1)
    {
        return stringsToDraw.Take(6).ToArray();

    }
    else if (Iteration > 1)
    {
        try
        {
            int skipValues = (Iteration - 1) * 6;
            return stringsToDraw.Take(6).Skip(skipValues).ToArray();
        }
        catch (Exception)
        {
            throw new Exception("Reached End of List");
        }
    }
    return default;
}















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

/*string Day3Url = "https://adventofcode.com/2021/day/3/input";
Day3 day3 = new Day3(Day3Url);
var content = day3.Day3Challenge(Day3Url);
string[] gammaAndEpsilpon = day3.GetGammaAndEpsilon(content);
var gamma = Convert.ToInt32(gammaAndEpsilpon[0] , 2);
var gammaByte = gammaAndEpsilpon[0];
var epsilonByte = gammaAndEpsilpon[1];
var epsilon = Convert.ToInt32(gammaAndEpsilpon[1] , 2);
var powerConsumption = gamma * epsilon;


var OxygenRating = day3.GetOygenGeneratorRating(content)[0];
int finalO2 = Convert.ToInt32(OxygenRating , 2);
var CO2Thing = day3.CO2ScrubberRating(content)[0];
int finalCO2 = Convert.ToInt32(CO2Thing , 2);
var solution = finalO2 * finalCO2;
Console.WriteLine(OxygenRating);*/








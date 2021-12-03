using System;
using System.Net;
using System.IO;
string URL;
URL = "https://adventofcode.com/2021/day/1/input";
HttpClient client = new HttpClient();
client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.28.4");
client.DefaultRequestHeaders.Add("Cookie", "ga=GA1.2.1719166319.1638429604; _gid=GA1.2.1368088148.1638429604; ru=53616c7465645f5fbc1beae71867dbde1cd6f543547de7a0d7defd5aab477fc738cfb5e159952b3733a39d3f82aa7390; session=53616c7465645f5fcddc49815a84d4a744d05475ba81e62690a7ce423cb7fcc1388495ca8f466e212db80d4ecabd17d2");
client.DefaultRequestHeaders.Add("Host", "adventofcode.com");

var content = await client.GetStringAsync(URL);
string[] depth_measurements = content.Split(new string[] { "\n" }, StringSplitOptions.None);
int array_length = depth_measurements.Length;
List<int> differencesList = new List<int>();

for (int i = 0; i < array_length - 1; i++)
{
    int minuend = Int32.Parse(depth_measurements[i + 1]);
    int subtrahend = Int32.Parse(depth_measurements[i]);
    int diff = minuend - subtrahend;
    differencesList.Add(diff);
    var positive_depths = differencesList.Where(x => x > 0).Count();

}

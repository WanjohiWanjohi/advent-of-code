using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
   public class InputClass
    {
        public string? ResourceUrl { get; set; }

        public InputClass()
        {

        }
        public HttpClient CreateHttpClient()

        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.28.4");
            client.DefaultRequestHeaders.Add("Cookie", "ga=GA1.2.1719166319.1638429604; _gid=GA1.2.1368088148.1638429604; ru=53616c7465645f5fbc1beae71867dbde1cd6f543547de7a0d7defd5aab477fc738cfb5e159952b3733a39d3f82aa7390; session=53616c7465645f5fcddc49815a84d4a744d05475ba81e62690a7ce423cb7fcc1388495ca8f466e212db80d4ecabd17d2");
            client.DefaultRequestHeaders.Add("Host", "adventofcode.com");
            return client;

        }
        async public Task<string[]> GetContentAsync(string url, HttpClient client)
        {
            var content = await client.GetStringAsync(url);
            string[] StringInput = content.Split(new string[] { "\n" }, StringSplitOptions.None);
            return StringInput;
        }
    }
}

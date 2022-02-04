using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
   public class InputClass
    {
        public virtual string? resourceUrl { get; set; }
        public InputClass()
        {

        }
        public HttpClient CreateHttpClient()

        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "PostmanRuntime/7.28.4");
            client.DefaultRequestHeaders.Add("Cookie", "_ga=GA1.2.1671151892.1643713550; _gid=GA1.2.363398169.1643713550; session=53616c7465645f5f8fae27383967383e065b787a9976eccd01355f9fd5378c2891ad4fdb363128fcaedc03e8c225b8f5");
            client.DefaultRequestHeaders.Add("Host", "adventofcode.com");
            return client;

        }
        async public Task<string[]> GetContentAsync( HttpClient client)
        {
            var content = await client.GetStringAsync(resourceUrl);
            string[] StringInput = content.Split(new string[] { "\n" }, StringSplitOptions.None);
            return StringInput;
        }
    }
}

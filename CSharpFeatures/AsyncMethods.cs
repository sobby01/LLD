using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class AsyncMethods
    {

        async Task<int> AddMethod()
        {
            Task<string> tUrl = new HttpClient().GetStringAsync("http://google.com");
            string rt = await tUrl;

            return rt.Length;
        }
    }
}

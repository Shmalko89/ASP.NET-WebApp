using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET_WebApp
{
    class GetMessageAsync
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task PostAsync()
        {
            for (int i = 4; i <= 13; i++)
            {
                try
                {
                    await GetMessage(i);
                }
                catch (AggregateException exeptoin)
                {
                    Console.WriteLine(exeptoin);
                }
            }
        }

        public async Task GetMessage(int id)
        {
            var message = await _httpClient.GetStringAsync($"https://jsonplaceholder.typicode.com/posts/{id}");
            Console.WriteLine(message);
            using StreamWriter text = new StreamWriter("result.txt", true);
            await text.WriteLineAsync(message);
        }
    }
}


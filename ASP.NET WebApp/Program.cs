using System;
using System.Threading.Tasks;

namespace ASP.NET_WebApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GetMessageAsync getMessage = new GetMessageAsync();
            await getMessage.PostAsync();
            Console.ReadLine();
        }
    }
}

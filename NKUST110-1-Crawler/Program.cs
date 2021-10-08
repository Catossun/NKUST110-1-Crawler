using System;
using System.Threading.Tasks;

namespace NKUST110_1_Crawler
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var data = await Repository.FetchDataAsync();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
    }
}
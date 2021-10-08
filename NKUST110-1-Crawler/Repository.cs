using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NKUST110_1_Crawler
{
    internal class Repository
    {
        private static string DATA_URL = "https://www.post.gov.tw/post/internet/Templates/getOpenDataFile.jsp?vkey=85422E4D-6133-4404-851E-08EC2077A162";

        public static async Task<IEnumerable<PostStation>> FetchDataAsync()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(DATA_URL);
            var contentStream = await response.Content.ReadAsStreamAsync();
            CsvReader reader = new CsvReader(
                new StreamReader(contentStream),
                new CsvConfiguration(CultureInfo.InvariantCulture)
            );
            return reader.GetRecords<PostStation>();
        }
    }
}
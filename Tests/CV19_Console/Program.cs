﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CV19_Console
{
    class Program
    {
        private const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";

        private static async Task<Stream> GetDataStream()
        {
            var client = new HttpClient();
            var respons = await client.GetAsync(data_url, HttpCompletionOption.ResponseHeadersRead);
            return await respons.Content.ReadAsStreamAsync();
        }
        
        private static IEnumerable<string> GetDataLines()
        {
            using (var data_stream = GetDataStream().Result)
            {
                using (var data_reader = new StreamReader(data_stream))
                {
                    while (!data_reader.EndOfStream)
                    {
                        var line = data_reader.ReadLine();
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        yield return line;
                    }
                }
            }
        }
        
        
        static void Main(string[] args)
        {
            //var client = new HttpClient();
            //var respons = client.GetAsync(data_url).Result;
            //var csv_str = respons.Content.ReadAsStringAsync().Result;

            foreach (var data_line in GetDataLines())
                Console.WriteLine(data_line);


            Console.ReadLine();
        }
    }
}

﻿using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace ConsoleApp
{
    internal class Program
    {
        private const string data_url = @"https://raw.githubusercontent.com/CSSEGISandData/COVID-19/master/csse_covid_19_data/csse_covid_19_time_series/time_series_covid19_confirmed_global.csv";


        // возвращает поток
        private static async Task<Stream> GetDataStream()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(data_url, HttpCompletionOption.ResponseHeadersRead);
            return await response.Content.ReadAsStreamAsync();
        }

        private static IEnumerable<string> GetDataLines()
        {
            using var data_stream = GetDataStream().Result;
            using var data_reader = new StreamReader(data_stream);


            while (!data_reader.EndOfStream)
            {
                var line = data_reader.ReadLine();

                if (string.IsNullOrEmpty(line)) continue;

                yield return line;

            }

        }


        private static DateTime[] GetDates() => GetDataLines()
            .First()
            .Split(",")
            .Skip(4)
            .Select(s => DateTime.Parse(s, CultureInfo.InvariantCulture))
            .ToArray();








        static void Main(string[] args)
        {
            //var client = new HttpClient(); 

            //var respose = client.GetAsync(data_url).Result;

            //var data_csv = respose.Content.ReadAsStringAsync().Result;

            //Console.ReadLine();


            var dates = GetDates();
            Console.WriteLine(string.Join("\r\n", dates));

        }
    }
}
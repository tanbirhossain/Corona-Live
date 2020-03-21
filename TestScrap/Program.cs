using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Model;
using BLL.Services;
using HtmlAgilityPack;
using Newtonsoft.Json;
using ScrapySharp.Extensions;

namespace TestCorona
{
    class Program
    {
        public static CoronaService _coronaService = new CoronaService();
        static void Main(string[] args)
        {
            Console.WriteLine(JsonConvert.SerializeObject(_coronaService.GetTodayResult(), Formatting.Indented));
            Console.ReadLine();

        }
    }
}

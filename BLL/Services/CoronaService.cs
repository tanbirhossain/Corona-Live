using BLL.Model;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CoronaService
    {
        public CoronaReturnVM GetTodayResult()
        {
            CoronaReturnVM returnVM = new CoronaReturnVM();
            List<CoronaVM> coronaList = new List<CoronaVM>();
            TotalCoronaVM totalCoronaVM = new TotalCoronaVM();
            var url = "https://www.worldometers.info/coronavirus/";
            var webGet = new HtmlWeb();
            if (webGet.Load(url) is HtmlDocument document)
            {

                var nodes = document.DocumentNode.CssSelect("#main_table_countries_today tbody tr").ToList();
                var _lastNode = nodes.Last();
                nodes.Remove(_lastNode);
                foreach (var node in nodes)
                {
                    var innerList = node.CssSelect("td").ToList();
                    var model = new CoronaVM();
                    model.Country = innerList[0].InnerText;
                    model.Total_Cases = Convert.ToInt32(innerList[1].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[1].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.New_Cases = Convert.ToInt32(innerList[2].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[2].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.Total_Deaths = Convert.ToInt32(innerList[3].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[3].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.New_Deaths = Convert.ToInt32(innerList[4].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[4].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.Total_Recovered = Convert.ToInt32(innerList[5].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[5].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.Active_Cases = Convert.ToInt32(innerList[6].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[6].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.Serious_Critical = Convert.ToInt32(innerList[7].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[7].InnerText.Replace("+", "").Replace(",", "").Trim());
                    model.Tot_Cases = Convert.ToDouble(innerList[8].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : innerList[8].InnerText.Replace("+", "").Replace(",", "").Trim());
                    coronaList.Add(model);

                }

                //Total
                var lastNode = _lastNode.CssSelect("td").ToList();
                totalCoronaVM.Total_Cases = Convert.ToInt32(lastNode[1].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[1].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_New_Cases = Convert.ToInt32(lastNode[2].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[2].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_Deaths = Convert.ToInt32(lastNode[3].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[3].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_New_Deaths = Convert.ToInt32(lastNode[4].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[4].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_Recovered = Convert.ToInt32(lastNode[5].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[5].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_Active_Cases = Convert.ToInt32(lastNode[6].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[6].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Total_Serious_Critical = Convert.ToInt32(lastNode[7].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[7].InnerText.Replace("+", "").Replace(",", "").Trim());
                totalCoronaVM.Tot_Cases = Convert.ToDouble(lastNode[8].InnerText.Replace("+", "").Replace(",", "").Trim() == "" ? "0" : lastNode[8].InnerText.Replace("+", "").Replace(",", "").Trim());

            }
            returnVM.Total = totalCoronaVM;
            returnVM.List = coronaList;
    

            return returnVM;

        }
    }
}

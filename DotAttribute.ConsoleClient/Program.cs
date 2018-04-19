using System;
using HtmlAgilityPack;
using System.Text.RegularExpressions;
using System.Linq;
using DotAttribute.Repo;
using Newtonsoft.Json;
using System.Drawing;

namespace DotAttribute.ConsoleClient
{
	class Program
	{
		static void Main(string[] args)
		{
            //foreach (var html in Crawler.GetAllHeroHomepages())
            //{
            //	Console.WriteLine(html);
            //}
            Crawler.GetAllHeroHomepages();
            Console.WriteLine("done");
            //HtmlDocument doc = new HtmlDocument();
            //doc.Load("abbadonsamplehomepage.html");
            //var attributesUnformatted = doc.DocumentNode.SelectSingleNode("//table/tr/td/table").InnerText;
            //var matches = new Regex(@"\d*\D\d.?\d?").Matches(attributesUnformatted).Select(b => Convert.ToDouble(b.Value)).ToList();

            //var heroAttr = new AttributeModel
            //{
            //    Strength = matches[0],
            //    StrGain = matches[1],
            //    Agility = matches[2],
            //    AgiGain = matches[3],
            //    Intelligence = matches[4],
            //    IntGain = matches[5]
            //};

            //#region "data generation for google graph"
            //double[,] heroStrGraph = new double[25, 2];

            //for (int i = 0; i < 25; i++)
            //{
            //    heroStrGraph[i, 0] = i + 1;
            //    heroStrGraph[i, 1] = heroAttr.Strength + Math.Round((heroAttr.StrGain * (i + 1)), 1);
            //}

            //var json = JsonConvert.SerializeObject(heroStrGraph);

            ////Console.WriteLine(json);
            //#endregion

            //#region "data generation for chart js"

            //var CJSData = new ChartJsData();
            //for (int i = 0; i < 25; i++)
            //{
            //    CJSData.data[i] = (Math.Round(heroAttr.Strength + (heroAttr.StrGain * (i + 1)), 1));
            //}

            //CJSData.label = "Abaddon strength";
            ////TODO: investigate System.Drawing.ColorConvertor
            //CJSData.borderColor = "#3e95cd";
            //CJSData.fill = false;

            //var json2 = JsonConvert.SerializeObject(CJSData);

            //Console.WriteLine(json2);

            //#endregion

        }
    }
}
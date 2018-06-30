using System.Net;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Resources;
using System.Text;
using System;
using HtmlAgilityPack;

namespace DotAttribute.Repo
{
    //public static class NameRetriever
    //{
    //    //private static readonly string SteamAPIKey = "BEC626D079208F178B7CB1524F2AF3E8";
    //    //private static readonly string SteamID = "76561198039262492";
    //    //private static readonly string HeroEndpoint = "https://api.steampowered.com/IEconDOTA2_570/GetHeroes/v1/";


    //    public static List<string> GetAllHeroes()
    //    {
    //        //string endpoint = $"{HeroEndpoint}?key={SteamAPIKey}";
    //        //string heroesString;
    //        List<string> results = new List<string>();

    //        //using (var client = new WebClient())
    //        //{
    //        //	heroesString = client.DownloadString(endpoint);
    //        //}

    //        var heroesJson = JsonConvert.DeserializeObject<Heroes>(MyResources.heroes);

    //        foreach (Hero i in heroesJson.result.heroes)
    //        {
    //            results.Add(CleanUpName(i.name));
    //        }
    //        results.Sort();
    //        return results;
    //    }

    //    private static string CleanUpName(string name)
    //    {
    //        return name.Substring(14);
    //    }
    //}


    public class NameRetriever
    {
        private const string HeroSourcePage = "https://dota2.gamepedia.com/Heroes";

        public List<string> GetAllHeroes()
        {
            var data = GetHeroesNamePage();
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(data);

            var heroesTable = doc.DocumentNode.SelectSingleNode("//table");
            var heroNames = new List<string>();
            bool keepCounting = true;
            for (int i = 2; i < 7; i += 2)
            {
                int j = 1;
                while(keepCounting == true)
                {
                    var heroname = heroesTable.SelectSingleNode($"//tr[{i}]/td/div[{j}]/div[1]/a")?.Attributes["href"].Value;
                    if (string.IsNullOrEmpty(heroname))
                    {
                        keepCounting = false;
                    }
                    else
                    {
                        heroNames.Add(heroname);
                        j++;
                    }
                }
                keepCounting = true;
            }
            return heroNames;
        }


        public string GetHeroesNamePage()
        {
            using (var client = new WebClient())
            {
                try
                {
                    return client.DownloadString(HeroSourcePage);
                }
                catch (Exception)
                {
                    return $"hero name page is broken";
                }
            }
        }
    }


    //rattlesnake = clockwerk
    //wisp = io
    //zuus = zeus
    //antimage = anti-mage
}

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Linq;

namespace DotAttribute.Repo
{
    public static class Crawler
    {
        //static WebClient client = new WebClient();

        public static List<string> GetAllHeroHomepages()
        {
            var list = new List<string>();
            var data = new NameRetriever().GetAllHeroes();
            foreach(string hero in data){
                System.IO.File.AppendAllText($"../../../../hero web pages{hero}.html", GetHeroHomepage(hero));
            }
            

            //foreach (var hero in data)
            //{
            //	list.Add(Crawler.GetHeroHomepage(hero));
            //}
            
            return list;
        }

        public static string GetHeroHomepage(string heroName)
        {
            using (var client = new WebClient())
            {
                try
                {
                    return client.DownloadString($"https://dota2.gamepedia.com{heroName}");
                }
                catch (Exception)
                {
                    return $"{heroName} is broken";
                }
            }
        }


    }
}

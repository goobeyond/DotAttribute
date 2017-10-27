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
	
		public static string GetHeroHomepage(string heroName)
		{
			using (var client = new WebClient())
			{
				try
				{
					return client.DownloadString($"https://dota2.gamepedia.com/{heroName}");
				}
				catch (System.Exception)
				{
					return string.Empty;
				}
			}
		}

		public static List<string> GetAllHeroHomepages()
		{
			var list = new List<string>();
			var data = NameRetriever.GetAllHeroes();
			System.IO.File.AppendAllText("abbadonsamplehomepage.txt", Crawler.GetHeroHomepage(data.First()));

			//foreach (var hero in data)
			//{
			//	list.Add(Crawler.GetHeroHomepage(hero));
			//}

			return list;
		}

	}
}

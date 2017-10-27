using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Resources;
using System.Text;

namespace DotAttribute.Repo
{
	public static class NameRetriever
	{
		//private static readonly string SteamAPIKey = "BEC626D079208F178B7CB1524F2AF3E8";
		//private static readonly string HeroEndpoint = "https://api.steampowered.com/IEconDOTA2_570/GetHeroes/v0001/";
		

		public static List<string> GetAllHeroes()
		{
			//string endpoint = $"{HeroEndpoint}?key={SteamAPIKey}";
			//string heroesString;
			List<string> results = new List<string>();

			//using (var client = new WebClient())
			//{
			//	heroesString = client.DownloadString(endpoint);
			//}

			var heroesJson = JsonConvert.DeserializeObject<Heroes>(MyResources.heroes);

			foreach(Hero i in heroesJson.result.heroes)
			{
				results.Add(CleanUpName(i.name));
			}
			results.Sort();
			return results;
		}

		private static string CleanUpName(string name)
		{
			return name.Substring(14);
		}
	}

	//rattlesnake = clockwerk
	//wisp = io
	//zuus = zeus
	//antimage = anti-mage
}

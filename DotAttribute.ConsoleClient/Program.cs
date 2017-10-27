using System;
using DotAttribute.Repo;

namespace DotAttribute.ConsoleClient
{
	class Program
	{
		static void Main(string[] args)
		{
			foreach (var html in Crawler.GetAllHeroHomepages())
			{
				Console.WriteLine(html);
			}
		}
	}
}

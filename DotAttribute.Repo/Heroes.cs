using System;
using System.Collections.Generic;
using System.Text;

namespace DotAttribute.Repo
{
	public class Heroes
	{
		public Result result { get; set; }

	}
	public class Result
	{
		public Hero[] heroes { get; set; }
		public int status { get; set; }
		public int count { get; set; }
	}

	public class Hero
	{
		public string name { get; set; }
		public int id { get; set; }
	}
}

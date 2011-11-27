namespace WYSTTS.Ruby
{
	using System;
	using System.Dynamic;

	public class Example
	{
		public void LookAtMe()
		{
			Get("/hello/:name", (param) => {
				return String.Format("Hello {0}!", param.name);
			});
		}

		private void Get(string path, Func<dynamic, string> param)
		{
			// Do your cool stuff here :)
		}

		/*

		Other usages of this where demonstrated using NancyFx.
		To find Nancy samples, documentation and source code
		please checkout:

		http://github.com/NancyFx/Nancy
		
		*/
	}

	public static class Program
	{
		public static void Main(string[] args) {}
	}
}
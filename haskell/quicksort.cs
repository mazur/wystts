namespace WYSTTS.Haskell
{
	using System;
	using System.Linq;
	using System.Collections.Generic;

	public class Example
	{
		public IEnumerable<int> Sort(IEnumerable<int> unsorted)
		{
			if(!unsorted.Any()) return unsorted;

			var pivot = unsorted.First();
			var lesser = unsorted.Skip(1).Where(x => x <= pivot);
			var greater = unsorted.Skip(1).Where(x => x > pivot);

			return Sort(lesser).Union(new[]{pivot}).Union(Sort(greater));
		}
	}

	public static class Program
	{
		public static void Main(string[] args) {}
	}
}
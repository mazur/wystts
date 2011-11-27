namespace WYSTTS.Eiffel
{
	using System;

	public class Example
	{
		private int _minutes;

		public int Minute
		{
			get { return this._minutes % 60; }
		}

		public int Hour
		{
			get { return this._minutes / 60; }
		}

		public void Set(int hour, int minute)
		{
			// Require
			if((0 < hour && hour >= 24) || (0 < minute && minute >= 60))
			{
				throw new RequireException();
			}
			
			// Do
			this._minutes = (hour * 60) + minute;
			
			// Ensure
			if(this.Minute != minute || this.Hour != hour)
			{
				throw new EnsureException();
			}
		}
	}

	public class RequireException : Exception {}
	public class EnsureException : Exception {}

	public static class Program
	{
		public static void Main(string[] args) {}
	}
}
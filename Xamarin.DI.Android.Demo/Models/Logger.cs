namespace Xamarin.DI.Android.Demo.Models
{
	using System;

	public class Logger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
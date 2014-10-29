using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin.DI.Android.Demo
{
	public class Logger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
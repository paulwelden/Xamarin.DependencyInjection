using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Xamarin.DI.Android.Demo
{
	[Activity(Label = "Xamarin.DI.Android.Demo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : DIActivity
	{
		int _count;

		public ILogger Logger { get; set; }


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.MyButton);

			button.Click += delegate
			{
				_count++;
				if (Logger != null) Logger.Log(string.Format("Log: {0} clicks!", _count));
				button.Text = string.Format("{0} clicks!", _count);
			};
		}
	}
}


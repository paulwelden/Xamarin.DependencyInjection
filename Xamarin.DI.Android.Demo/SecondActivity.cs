using Android.App;
using Android.OS;

namespace Xamarin.DI.Android.Demo
{
	using global::Android.Views;
	using global::Android.Widget;
	using Models;

	[Activity(Label = "SecondActivity")]
	public class SecondActivity : DIActivity
	{

	
		public ILogger Logger { get; set; }
		public ICountRepository CountRepository { get; set; }


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var button = FindViewById<Button>(Resource.Id.MyButton);
			if (CountRepository.CurrentCount > 0) button.Text = string.Format("{0} clicks!", CountRepository.CurrentCount);

			button.Click += delegate
			{
				CountRepository.CurrentCount++;
				if (Logger != null) Logger.Log(string.Format("Log SecondActivity: {0} clicks!", CountRepository.CurrentCount));
				button.Text = string.Format("{0} clicks!", CountRepository.CurrentCount);
			};

			var buttonNav = FindViewById<Button>(Resource.Id.MyNavButton);
			buttonNav.Visibility = ViewStates.Gone;
			
		}
	}
}
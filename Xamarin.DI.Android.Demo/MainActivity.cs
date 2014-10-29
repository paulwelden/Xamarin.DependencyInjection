using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.DI.Android.Demo
{
	using global::Android.Content;
	using Models;

	[Activity(Label = "Xamarin.DI.Android.Demo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : DIActivity
	{
		private Button _button;

		public ILogger Logger { get; set; }
		public ICountRepository CountRepository { get; set; }

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			_button = FindViewById<Button>(Resource.Id.MyButton);

			_button.Click += delegate
			{
				CountRepository.CurrentCount++;				
				if (Logger != null) Logger.Log(string.Format("Log MainActivity: {0} clicks!", CountRepository.CurrentCount));
				UpdateVisibleCount();
				
			};

			var buttonNav = FindViewById<Button>(Resource.Id.MyNavButton);

			buttonNav.Click += delegate
			{
				if (Logger != null) Logger.Log("Navigate to the Second Activity");
				var secondActivity = new Intent(this, typeof (SecondActivity));
				StartActivity(secondActivity);
			};
		}


		protected override void OnResume()
		{
			base.OnResume();
			UpdateVisibleCount();
		}

		private void UpdateVisibleCount()
		{
			_button.Text = string.Format("{0} clicks!", CountRepository.CurrentCount);
		}
	}
}
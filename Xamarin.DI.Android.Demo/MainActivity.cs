namespace Xamarin.DI.Android.Demo
{
	using System;
	using global::Android.App;
	using global::Android.Content;
	using global::Android.OS;
	using global::Android.Widget;
	using Models;

	[Activity(Label = "Xamarin.DI.Android.Demo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : DIActivity
	{
		private Button _button;

		public Lazy<ILogger> Logger { get; set; } //lazily load the logger
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
				if (Logger.Value != null)
					Logger.Value.Log(string.Format("Log MainActivity: {0} clicks!", CountRepository.CurrentCount));
				UpdateVisibleCount();
			};

			var buttonNav = FindViewById<Button>(Resource.Id.MyNavButton);

			buttonNav.Click += delegate
			{
				if (Logger.Value != null) Logger.Value.Log("Navigate to the Second Activity");
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
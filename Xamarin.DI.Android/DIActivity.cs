namespace Xamarin.DI.Android
{
	using Core;
	using global::Android.App;
	using global::Android.OS;

	public class DIActivity : Activity
	{
		public static IXamarinResolver Resolver;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			if (Resolver != null)
				Resolver.ResolveProperties(this);
			//because we are not in control of the Activity Lifecycle, dependencies can only be injected through properties.
		}
	}
}
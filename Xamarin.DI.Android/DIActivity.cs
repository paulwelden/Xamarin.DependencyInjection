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

			if(Resolver != null)
				Resolver.ResolveProperties(this);

			base.OnCreate(savedInstanceState);
		}
	}


}
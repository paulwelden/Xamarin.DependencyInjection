using Android.App;

namespace Xamarin.DI.Android.Demo
{
	using System;
	using App_Start;
	using global::Android.Runtime;

	[Application]
	public class DIApplication : Application
	{


		public DIApplication(IntPtr doNotUse, JniHandleOwnership transfer)
			: base(doNotUse, transfer) { }

		public override void OnCreate()
		{
			DependencyConfig.Register();


			base.OnCreate();
		}
	}
}
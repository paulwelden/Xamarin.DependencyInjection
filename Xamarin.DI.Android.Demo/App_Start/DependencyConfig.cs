namespace Xamarin.DI.Android.Demo.App_Start
{
	using LightInject;


	public static class DependencyConfig
	{



		public static void Register()
		{

			var container = new LightInjectResolver();
			
			container.Register<ILogger, Logger>();

			DIActivity.Resolver = container;


		}





	}
}
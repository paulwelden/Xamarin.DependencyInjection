namespace Xamarin.DI.Android.Demo.App_Start
{
	using Core;
	using LightInject;
	using Models;


	public static class DependencyConfig
	{



		public static void Register()
		{

			var container = new LightInjectResolver();
			
			container.Register<ILogger, Logger>();
			container.Register<ICountRepository, CountRepository>(XamarinResolverLifetime.PerContainerLifetime);

			DIActivity.Resolver = container;


		}





	}
}
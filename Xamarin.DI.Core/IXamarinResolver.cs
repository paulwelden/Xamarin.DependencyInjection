namespace Xamarin.DI.Core
{
	public enum XamarinResolverLifetime
	{
		PerScopeLifetime,
		PerContainerLifetime		
	}


	public interface IXamarinResolver
	{
		T Resolve<T>();

		void ResolveProperties(object instance);

		void Register<TService, TImplementation>() where TImplementation : TService;

		void Register<TService, TImplementation>(XamarinResolverLifetime lifetime) where TImplementation : TService;
	}
}
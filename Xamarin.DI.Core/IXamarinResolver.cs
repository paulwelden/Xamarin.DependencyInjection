namespace Xamarin.DI.Core
{
	public interface IXamarinResolver
	{

		T Resolve<T>();

		void ResolveProperties(object instance);

		void Register<TService, TImplementation>() where TImplementation : TService;

	}
}

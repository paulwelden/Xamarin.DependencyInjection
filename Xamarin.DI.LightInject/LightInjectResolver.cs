namespace Xamarin.DI.LightInject
{
	using Core;
	using global::LightInject;


	public class LightInjectResolver : IXamarinResolver
	{
		private readonly IServiceContainer _container;

		public LightInjectResolver()
		{
			_container = new ServiceContainer();
		}

		public T Resolve<T>()
		{
			return _container.GetInstance<T>();
		}

		public void ResolveProperties(object instance)
		{
			_container.InjectProperties(instance);
		}

		public void Register<TService, TImplementation>() where TImplementation : TService
		{
			_container.Register<TService, TImplementation>();
		}
	}
}

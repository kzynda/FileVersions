using Ninject.Modules;

namespace Core
{
	public class CoreModule : NinjectModule
	{
		public override void Load()
		{
		//	Bind<ISomeInterface>().To<SomeClass>();
		//	Bind<ICalculate>().To<Calculate>();
			Bind<IApp>().To<App>();
		} //TODO KŻ add module initialization
	}
}
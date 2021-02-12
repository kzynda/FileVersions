using Ninject.Modules;

namespace Core
{
	public class CoreModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IApp>().To<App>();
		} 
	}
}
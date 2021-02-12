using Core;
using Ninject;

namespace PocConsoleApp
{
	internal static class Program
	{
		private static void Main()
		{
			var kernel = InitDependencyInjection();

			var start = kernel.Get<IApp>();

			var cfg = InitConfiguration();

			start.Run(cfg);
		}

		private static StartupConfiguration InitConfiguration()
		{
			var cfg = new StartupConfiguration();

			return cfg;
		}

		private static IKernel InitDependencyInjection()
		{
			IKernel kernel = new StandardKernel(new CoreModule());

			return kernel;
		}
	}
}

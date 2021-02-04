using Core;
using Ninject;

namespace PocConsoleApp
{
	internal static class Program
	{
		private static void Main(string[] args)
		{
			var kernel = InitDependencyInjection();

			var strat = kernel.Get<IApp>();

			StartupConfiguration cfg = InitConfiguration(args);

			strat.Run(cfg);
		}

		private static StartupConfiguration InitConfiguration(string[] args)
		{
			StartupConfiguration cfg = new StartupConfiguration()
				{ };

			return cfg;
		}

		private static IKernel InitDependencyInjection()
		{
			IKernel kernel = new StandardKernel(new CoreModule());

			return kernel;
		}
	}
}

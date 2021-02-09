using System;

namespace Core
{
	public class App : IApp
	{
		public void Run(StartupConfiguration cfg)
		{
			Console.Write("Run");
			Console.ReadKey();
		}
	}
}
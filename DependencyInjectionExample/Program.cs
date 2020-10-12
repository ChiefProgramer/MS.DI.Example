using Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjectionExample {
	class Program {
		private static ILaunchPoint _Launch;

		static void Main(string[] args) {
			ConfigureDI();
			_Launch.Execute(args);
		}
		 
		//Configure DI Service and Get Launch Point 
		private static void ConfigureDI() {
			ServiceCollection vServiceCollection = new ServiceCollection();

			//Register Dependencies with DI Service
			RegisterDIServices.ConfigureDIServices(vServiceCollection);
			ServiceProvider vServiceProvider = vServiceCollection.BuildServiceProvider();

			//Kickoff DI
			_Launch = vServiceProvider.GetService<ILaunchPoint>();
		}

	}
}

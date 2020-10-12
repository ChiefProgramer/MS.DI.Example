using Contracts;
using ExampleService;
using ExampleService2;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExample {
	public static class RegisterDIServices {
		//Register Dependencies with DI Service 
		public static void ConfigureDIServices(IServiceCollection aCollection) {

			aCollection.AddSingleton<IHelloWorldService, HelloWorldService>();
			aCollection.AddTransient<IHelloWorldTextService, HelloWorldTextService>();

			//Launch
			aCollection.AddSingleton<ILaunchPoint, LaunchPoint>();
		}
	}
}

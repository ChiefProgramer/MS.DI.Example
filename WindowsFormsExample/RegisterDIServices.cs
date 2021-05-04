using Contracts;
using I = Contracts.Forms;
using ExampleService;
using ExampleService2;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsFormsExample;

namespace DependencyInjectionExample {
	public static class RegisterDIServices {
		//Register Dependencies with DI Service 
		public static void ConfigureDIServices(IServiceCollection aCollection) {

			aCollection.AddSingleton<IHelloWorldService, HelloWorldService>();
			aCollection.AddTransient<IHelloWorldTextService, HelloWorldTextService>();
			aCollection.AddTransient<Form, Form1>();

			//Launch
			aCollection.AddSingleton<I.ILaunchPoint, LaunchPoint>();
		}
	}
}

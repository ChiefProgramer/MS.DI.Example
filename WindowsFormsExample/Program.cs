using Contracts.Forms;
using DependencyInjectionExample;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample {
	static class Program {
		private static ILaunchPoint _Launch;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ConfigureDI();

			_Launch.Execute(null);
			Application.Run(_Launch.Execute(null));
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

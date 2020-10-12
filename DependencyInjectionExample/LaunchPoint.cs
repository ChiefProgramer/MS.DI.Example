using Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample {
	class LaunchPoint : ILaunchPoint {
		IHelloWorldService _HelloWorldService;

		public LaunchPoint(IHelloWorldService aHelloWorldService) {
			_HelloWorldService = aHelloWorldService;
		}
		 
		public void Execute(string[] args) {
			_HelloWorldService.HelloWord();
		}

		public Task ExecuteAsync(string[] args) {
			throw new NotImplementedException();
		}
	}




}

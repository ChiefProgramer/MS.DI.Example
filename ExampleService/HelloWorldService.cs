using Contracts;
using System;

namespace ExampleService {
	public class HelloWorldService : IHelloWorldService {
		IHelloWorldTextService _HelloWorldTextService;

		public HelloWorldService(IHelloWorldTextService aHelloWorldTextService) {
			_HelloWorldTextService = aHelloWorldTextService;
		}

		public void HelloWord() {
			Console.WriteLine(_HelloWorldTextService.GetSomeText());
		}
	}
}

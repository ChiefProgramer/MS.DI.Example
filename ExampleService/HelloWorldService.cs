using Contracts;
using System;
using System.Diagnostics;

namespace ExampleService {
	public class HelloWorldService : IHelloWorldService {
		IHelloWorldTextService _HelloWorldTextService;

		public HelloWorldService(IHelloWorldTextService aHelloWorldTextService) {
			_HelloWorldTextService = aHelloWorldTextService;
		}

		public void HelloWord() {
			Console.WriteLine(_HelloWorldTextService.GetSomeText());
			Debug.WriteLine(_HelloWorldTextService.GetSomeText());
			
		} 

		public string HelloWordText() {
			return	_HelloWorldTextService.GetSomeText();
		}
	}
}

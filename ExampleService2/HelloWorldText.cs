using Contracts;
using System;

namespace ExampleService2 {
	public class HelloWorldTextService : IHelloWorldTextService { 

		public string GetSomeText() {
			return "Hello World";
		}
	}
}


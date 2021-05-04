using Contracts.Forms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjectionExample {
	class LaunchPoint : ILaunchPoint {
		Form _Form;

		public LaunchPoint(Form aForm) {
			_Form = aForm;
		}
		 
		public Form Execute(string[] args) {
			return _Form;
		}

		public Task<Form> ExecuteAsync(string[] args) {
			throw new NotImplementedException();
		}
	}




}

using System;
using Service.Services;

namespace Exceptions_HW.Controller
{
	public class FactorialController
	{
		public void CheckAndReleaseOutput()
		{
			int num = int.Parse(Console.ReadLine());
			FactorialService factorialService = new FactorialService();
			factorialService.CheckEnteredInput(num);
		}
	}
}


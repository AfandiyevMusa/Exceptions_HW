using System;
using Service.Services;

namespace Exceptions_HW.Controller
{
	public class LoginController
	{
		public void CheckUser()
		{
            Console.WriteLine("Username'i daxil edin: ");
            string? username = Console.ReadLine();

            Console.WriteLine("Email'i daxil edin: ");
            string? email = Console.ReadLine();

            Console.WriteLine("Password'i daxil edin: ");
            string? password = Console.ReadLine();

            LoginService accountService = new LoginService();

            accountService.CheckInfo(username, email, password);

		}
	}
}


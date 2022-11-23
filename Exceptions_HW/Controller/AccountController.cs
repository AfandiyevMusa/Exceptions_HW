using System;
using Domain.Models;
using Service.Services;

namespace Exceptions_HW.Controller
{
	public class AccountController
	{
		public void RegisterAccount()
		{
			try
			{
				Console.WriteLine("Please, enter username: ");
				string username = Console.ReadLine();
				
				Console.WriteLine("Please, enter email: ");
				string email = Console.ReadLine();

				Console.WriteLine("Please, enter password: ");
				string password = Console.ReadLine();

				AccountService accountService = new AccountService();

				User user = new User()
				{
					Username = username,
					Email = email,
					Password = password
				};
				var res = accountService.Register(user);

				if (!res)
				{
					throw new Exception("Email doesn't contain the symbol, @");
				}
				Console.WriteLine(res);

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public void GetID()
		{
			try
			{
				AccountService account = new AccountService();
				var res = account.GetUserID(1);
				Console.WriteLine(res.Username);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}


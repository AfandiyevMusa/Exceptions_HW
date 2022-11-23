using System;
using System.Text.RegularExpressions;
using Service.Exceptions;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class LoginService : ILoginService
	{
        public void CheckInfo(string username, string email, string password)
        {
            try
            {
                if (Regex.IsMatch(username, @"[0-9]"))
                {
                    throw new ShouldntContainNum("Username shouldn't contain number");
                }
                else if (!email.Contains("@"))
                {
                    throw new NotContainSymbol("Email should contain @");
                }
                else if (!(Regex.IsMatch(password, @"[0-9]")))
                {
                    throw new NotFoundExceptions("Password should contain at least nubmer");
                }
                Console.WriteLine("Logged in!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}


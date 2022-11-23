using System;
namespace Service.Services.Interfaces
{
	public interface ILoginService
	{
		public void CheckInfo(string username, string email, string password);

    }
}


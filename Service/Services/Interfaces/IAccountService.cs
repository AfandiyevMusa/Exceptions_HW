using System;
using Domain.Models;

namespace Service.Services.Interfaces
{
	public interface IAccountService
	{
		bool Register(User user);
		User GetUserID(int id);
	}
}


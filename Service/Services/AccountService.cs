using System;
using Domain.Models;
using Service.Exceptions;
using Service.Helpers.Constants;
using Service.Services.Interfaces;

namespace Service.Services
{
	public class AccountService : IAccountService
	{
        public User GetUserID(int id)
        {
            List<User> users = new List<User>();

            users.Add(new User { ID = 1, Username = "User1", Email = "User1@gmail.com", Password = "12345" });
            users.Add(new User { ID = 2, Username = "User2", Email = "User2@gmail.com", Password = "12345" });
            users.Add(new User { ID = 3, Username = "User3", Email = "User3@gmail.com", Password = "12345" });
            users.Add(new User { ID = 4, Username = "User4", Email = "User4@gmail.com", Password = "12345" });
            users.Add(new User { ID = 5, Username = "User5", Email = "User5@gmail.com", Password = "12345" });

            var res = users.Find(m => m.ID == id);

            if(res == null)
            {
                throw new NotFoundExceptions(ExceptionMessage.NotFound);
            }
            return res;
        }

        public bool Register(User user)
        {
            if (user.Email != null)
            {
                if (!user.Email.Contains("@"))
                {
                    return false;
                }
            }
            
            return true;
        }


    }
}


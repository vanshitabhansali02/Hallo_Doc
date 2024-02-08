using BusinessLogic.Interfaces;
using DataAccess.DataContext;
using DataAccess.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LoginService : ILoginService
    {
        private readonly ApplicationDbContext _dbContext; // Replace YourDbContext with your actual DbContext class

        public LoginService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool LoginUser(string username, string password)
        {
            var user=  _dbContext.Aspnetusers.FirstOrDefault(u =>
         u.Email == username &&
         u.Passwordhash == password);
            return user != null;

            // Implement your user validation logic here
            // Return true if the user is valid, false otherwise
        }
    }
}

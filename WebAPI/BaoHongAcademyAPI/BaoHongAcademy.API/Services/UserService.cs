using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaoHongAcademy.API.Interfaces;
using BaoHongAcademy.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BaoHongAcademy.API.Services
{
    public class UserService : IUserService
    {
        private readonly BaoHongContext _dbContext;

        public UserService(BaoHongContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Authenticate(string userName, string password)
        {
            var userAuthen = _dbContext.Users.Where(e => e.Email == userName && e.Password == password)
                .FirstOrDefault();

            return userAuthen != null;
        }
    }
}

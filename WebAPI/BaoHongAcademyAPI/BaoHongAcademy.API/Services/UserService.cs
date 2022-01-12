using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaoHongAcademy.API.Helpers;
using BaoHongAcademy.API.Interfaces;
using BaoHongAcademy.Domain.Entities;
using BaoHongAcademy.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BaoHongAcademy.API.Services
{
    public class UserService : IUserService
    {
        private readonly BaoHongContext _dbContext;
        private readonly AppSettings _appSettings;

        public UserService(BaoHongContext dbContext, IOptions<AppSettings> appSettings)
        {
            _dbContext = dbContext;
            _appSettings = appSettings.Value;
        }

        public string Authenticate(string userName, string password)
        {
            var userAuthen = _dbContext.Users.FirstOrDefault(e => e.Email == userName && e.Password == password);

            var token = (dynamic)null;
            if (userAuthen != null)
            {
                token = HelperMethods.GenerateJwtToken(userAuthen, _appSettings.SecretKey);
            }

            return token;
        }

        public User GetById(Guid id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.UserId == id);
        }
    }
}

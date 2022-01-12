﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaoHongAcademy.Domain.Entities;

namespace BaoHongAcademy.API.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// To authenticate user
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>Token</returns>
        public string Authenticate(string userName, string password);

        public User GetById(Guid id);
    }
}
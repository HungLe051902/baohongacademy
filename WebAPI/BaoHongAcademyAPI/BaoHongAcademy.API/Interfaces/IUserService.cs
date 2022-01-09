using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaoHongAcademy.API.Interfaces
{
    public interface IUserService
    {
        public bool Authenticate(string userName, string password);
    }
}

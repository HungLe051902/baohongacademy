using BaoHongAcademy.Domain.Models;
using BaoHongAcademy.Domain.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static BaoHongAcademy.Domain.Enums.EnumCommon;

namespace BaoHongAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost("authenticate")]
        public ActionServiceResult Authenticate(UserCred userCred)
        {
            if (userCred.UserName == "test" && userCred.Password == "123456@A")
            {
                return new ActionServiceResult(true, (int)AppCode.Success, "Đăng nhập thành công", "Token");
            }
            return new ActionServiceResult(false, (int)AppCode.Error, "Đăng nhập thành công", null);
        }
    }
}

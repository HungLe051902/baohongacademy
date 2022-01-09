using BaoHongAcademy.Domain.Models;
using BaoHongAcademy.Domain.Models.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaoHongAcademy.API.Interfaces;
using static BaoHongAcademy.Domain.Enums.EnumCommon;

namespace BaoHongAcademy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserService _userService;

        public AccountsController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        public ActionServiceResult Authenticate(UserCred userCred)
        {
            if (_userService.Authenticate(userCred.UserName, userCred.Password))
            {
                return new ActionServiceResult(true, (int)AppCode.Success, "Đăng nhập thành công", "Token");
            }
            return new ActionServiceResult(false, (int)AppCode.Error, "Đăng nhập thất bại", null);
        }
    }
}

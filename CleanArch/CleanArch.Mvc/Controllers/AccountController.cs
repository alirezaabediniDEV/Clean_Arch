using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Security;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;

namespace CleanArch.Mvc.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }
        [Route("Register")]
        [HttpPost]
        public IActionResult Register(RegisterViewModels register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            CheckUser checkUser = _userService.CheckUser(register.UserName, register.Email);
            if (checkUser !=CheckUser.Ok)
            {
                ViewBag.Check = checkUser;
                return View(register);
            }
            Domain.Models.User user=new User()
            {
                Email = register.Email.Trim().ToLower(),
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                UserName = register.UserName
            };
            _userService.RegisterUser(user);
            return View("SuccessRegister",register);
        }
    }
}

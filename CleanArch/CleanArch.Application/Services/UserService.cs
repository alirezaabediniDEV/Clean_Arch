using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Application.Interfaces;
using CleanArch.Application.Security;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;

namespace CleanArch.Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public CheckUser CheckUser(string userName, string email)
        {
            bool usernameValid = _userRepository.IsExistUserName(userName);
            bool emailValid = _userRepository.IsExistEmail(email.Trim().ToLower());

            if (usernameValid && emailValid)
            {
                return ViewModels.CheckUser.UserNameAndEmailNotValid;
            }
            else if (emailValid)
            {
                return ViewModels.CheckUser.EmailNotValid;
            }
            else if (usernameValid)
            {
                return ViewModels.CheckUser.UserNameNotValid;
            }
            else
            {
                return ViewModels.CheckUser.Ok;
            }
        }

        public int RegisterUser(User user)
        {
            _userRepository.AddUser(user);
            _userRepository.Save();
            return user.UserId;
        }

        public bool IsExistUser(string email, string password)
        {
            return _userRepository.IsExistUser(email.Trim().Trim(), PasswordHelper.EncodePasswordMd5(password));
        }
    }
}

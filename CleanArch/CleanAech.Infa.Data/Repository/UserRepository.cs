using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanAech.Infa.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infa.Data.Migrations;

namespace CleanArch.Infa.Data.Repository
{
    public class UserRepository:IUserRepository
    {
        private UniversityDBContext _context;

        public UserRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public bool IsExistEmail(string email)
        {
            return _context.Users.Any(u => u.UserName == email);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

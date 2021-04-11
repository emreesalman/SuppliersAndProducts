using Microsoft.EntityFrameworkCore;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Data
{
    public class AuthRepository : IAuthRepository
    {
        private  DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Admin> Login(Admin admin)
        {
            var user = _context.Admins.FirstOrDefault(x=>x.UserName==admin.UserName);
            if (user == null) {
                return null;
            }
            return user;

        }

        public async Task<Admin> Register(Admin admin)
        {
            await _context.Admins.AddAsync(admin);
            await _context.SaveChangesAsync();
            return admin;
        }

        public async Task<bool> UserExist(string userName)
        {
            var resault = await _context.Admins.AnyAsync(x => x.UserName == userName);
            if (resault) {
                return true;
            }
            return false;
        }
    }
}

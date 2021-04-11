using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Data
{
    public interface IAuthRepository
    {
        Task<Admin> Register(Admin admin);
        Task<Admin> Login(Admin admin);
        Task<bool> UserExist(string userName);
    }
}

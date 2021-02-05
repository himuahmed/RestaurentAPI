using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RestaurantsAPI.Data;
using RestaurantsAPI.Models;

namespace RestaurantsAPI.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<UserModel> _userManager;
        public AccountRepository(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> UserExists(string username)
        {
            if(await _userManager.Users.AnyAsync(u=> u.UserName == username))
                return true;

            return false;
        }
    }
}

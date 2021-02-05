using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantsAPI.Models;

namespace RestaurantsAPI.Data
{
    public class RestaurantDbContext : IdentityDbContext<UserModel>
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }
    }
}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RestaurantsAPI.Data;
using RestaurantsAPI.Models;

namespace RestaurantsAPI.Repository
{
    public interface IAccountRepository
    {
        Task<bool> UserExists(string username);
    }
}
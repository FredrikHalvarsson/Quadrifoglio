using Microsoft.EntityFrameworkCore;
using IlQuadrifoglioAPI.Data;
using IlQuadrifoglioAPI.Models;

namespace IlQuadrifoglioAPI.Services
{
    public class RestaurantService
    {
        private readonly ApplicationDbContext _context;

        public RestaurantService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _context.Restaurants.Include(r => r.Address).ToList();
        }
    }
}

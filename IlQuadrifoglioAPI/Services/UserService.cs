using IlQuadrifoglioAPI.Data;
using IlQuadrifoglioAPI.Models;

namespace IlQuadrifoglioAPI.Services
{
    public class UserService
    {
        private readonly ApplicationDbContext _dbContext;

        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task UpdateUserLocationAsync(ApplicationUser user)
        {

            // Save changes to the database
            await _dbContext.SaveChangesAsync();
        }
    }
}

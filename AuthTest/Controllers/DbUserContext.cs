using Microsoft.EntityFrameworkCore;

namespace JWTAuthTest.Controllers
{
    public class DbUserContext : DbContext
    {
        public DbSet<User> Users { get; internal set; }
    }
}
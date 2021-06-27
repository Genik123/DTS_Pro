using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ClientHairdressingDog> ClientHairdressingDog { get; set; }
        public DbSet<ClientHairdressingDogOrder> ClientHairdressingDogOrder { get; set; }

    }
}

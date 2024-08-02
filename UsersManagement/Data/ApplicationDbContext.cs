using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UsersManagement.Shared.Models;

namespace UsersManagement.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : IdentityDbContext<ApplicationUser>(options)
    {

        public DbSet<User> users { get; set; }
        public DbSet<Country> Countries {  get; set; } 
        public DbSet<SystemCode> SystemCodes {  get; set; } 
        public DbSet<SystemCodeDetails> SystemCodeDetails {  get; set; } 
    }
}
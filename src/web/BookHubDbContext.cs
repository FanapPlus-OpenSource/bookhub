using Microsoft.EntityFrameworkCore;
using Web.Models;

namespace Web
{
    public class BookHubDbContext : DbContext
    {
        public BookHubDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
using Books_Web_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Books_Web_App.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
        //public ApplicationDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using webapp_razor.Models;
namespace webapp_razor.Data;


public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
        
    }
    public DbSet<Category> Category {get; set;}
}

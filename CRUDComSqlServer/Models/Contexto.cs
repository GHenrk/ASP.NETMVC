using Microsoft.EntityFrameworkCore;

namespace CRUDComSqlServer.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }    
    
        public DbSet<Produto> Produto { get; set; }
    
    }

}

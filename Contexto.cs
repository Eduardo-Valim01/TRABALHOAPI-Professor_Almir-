using Microsoft.EntityFrameworkCore;

namespace TRABALHOAPI
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> option): base(option) { }

        public DbSet<Produto> Produtos { get; set; }

    }
}

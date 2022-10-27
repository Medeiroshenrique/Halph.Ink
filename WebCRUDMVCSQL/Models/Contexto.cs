using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVCSQL.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto>options):base(options) 
        {
        }

        public DbSet<login> login { get; set; }
        public DbSet<Projeto> projeto { get; set; }
        public DbSet<Designer> designer { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Formacao> formacao { get; set; }
        public DbSet<Servico> servico { get; set; }
        public DbSet<Administrador> administrador { get; set; }




    }
}

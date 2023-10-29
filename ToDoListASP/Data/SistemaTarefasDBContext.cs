using Microsoft.EntityFrameworkCore;
using ToDoListASP.Data.Map;
using ToDoListASP.Models;

namespace ToDoListASP.Data
{
    // Estamos configurando as tabelas e as configuracoes gerais do banco de dados.
    public class SistemaTarefasDBContext : DbContext
    {
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder); 
        }
    }
}

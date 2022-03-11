using Departamentos.Models;
using Microsoft.EntityFrameworkCore;

namespace Departamentos.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security=SSPI;Persist Security Info=False;User ID=DESKTOP-MGQASMN\jfabi;Initial Catalog=ProjetoA;Data Source=DESKTOP-MGQASMN\SQLEXPRESS
");
        }
    }
}

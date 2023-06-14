using Microsoft.EntityFrameworkCore;
using WebAppBloom.EntityConfigs;
using WebAppBloom.Models;//inserir não esquecer
namespace WebAppBloom.Contexts;

//DbContext --> Banco
//DbSet  --> Tabela

//Banco ":" herança
public class AppDbContext:DbContext{
   //Tabela - Criar a tabela
   //DbSet<Competencia>
   public DbSet<Competencia> Competencias => Set<Competencia>();//tabela

    //override - sobrescrita -polimorfismo
    //mesmo método sobrescrito
    //configurar conexão
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer("Server=LAB-F08-28;Database=WebAppBloom;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
    }

    //aplicar as configurações da tabela
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CompetenciaEntityConfig());
    }

}

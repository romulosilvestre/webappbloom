using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppBloom.Models;
namespace WebAppBloom.EntityConfigs;

//Interface é o mais alto nível de abstração
//Na orientação a objetos ela é a ponta do Icerberg
//Funciona com um contrato com as classes
//Obriga geralmente a implementação
//Vamos implementar um método da interface?
public class CompetenciaEntityConfig : IEntityTypeConfiguration<Competencia>
{

    //FLUENT API
    public void Configure(EntityTypeBuilder<Competencia> builder)
    {

         builder.ToTable("Competencia");
        /*
           Chave primária: identificador
           único - universal e imutável 
        */    
        
        builder.HasKey(c=>c.Id);

        builder.Property(c=>c.Id)
               .HasColumnName("Id");
        
        /*Coluna Bloom*/
        builder.Property(c=>c.ColunaBloom)
               .HasColumnName("ColunaBloom")
               .HasColumnType("varchar(60)")
               .IsRequired();

        /*Linha Bloom*/
        builder.Property(c=>c.LinhaBloom)
               .HasColumnName("LinhaBloom")
               .HasColumnType("varchar(60)")
               .IsRequired();
               
           
        
        
    }
}
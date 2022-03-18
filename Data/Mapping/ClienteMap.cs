using ERPService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ERPService.MappingModels
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.Property(x => x.Id) 
                   .ValueGeneratedOnAdd()   
                   .UseIdentityColumn();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("ID")
                .HasColumnType("int");

            
            builder.Property(x => x.CpfCnpj)
                .IsRequired()
                .HasColumnName("CPF_CNPJ")
                .HasColumnType("VARCHAR")
                .HasMaxLength(18);


            builder.Property(x => x.TipoCliente)
                .IsRequired()
                .HasColumnName("TIPO_CLIENTE")
                .HasColumnType("CHAR")
                .HasMaxLength(1);

            builder.Property(x => x.Cep)
                    .IsRequired()
                    .HasColumnName("CEP")
                    .HasColumnType("VARCHAR");


            builder.Property(x => x.Logradouro)
                    .IsRequired()
                    .HasColumnName("LOGRADOURO")
                    .HasColumnType("VARCHAR");

            builder.Property(x => x.Endereco)
                    .IsRequired()
                    .HasColumnName("ENDERECO")
                    .HasColumnType("VARCHAR");


            builder.Property(x => x.Numero)
                    .IsRequired()
                    .HasColumnName("NUMERO")
                    .HasColumnType("VARCHAR");

            builder.Property(x => x.Bairro)
                    .IsRequired()
                    .HasColumnName("BAIRRO")
                    .HasColumnType("VARCHAR");


            builder.Property(x => x.Cidade)
                    .IsRequired()
                    .HasColumnName("CIDADE")
                    .HasColumnType("VARCHAR");

            builder.Property(x => x.UF)
                    .IsRequired()
                    .HasColumnName("UF")
                    .HasColumnType("CHAR");

        }
    }
}

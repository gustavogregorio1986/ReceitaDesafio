using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ReceitaDesafio.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceitaDesafio.Data.Mappping
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("tb_Receita");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.NomeCliente)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Valor)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(x => x.Situacao)
                .IsRequired()
                .HasColumnType("nvarchar(40)");

            builder.Property(x => x.Descricao)
                .IsRequired()
                .HasColumnType("nvarchar(MAX)");

            builder.Property(x => x.DataEmissao)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(x => x.Turno)
                .IsRequired()
                .HasColumnType("nvarchar(30)");
        }
    }
}

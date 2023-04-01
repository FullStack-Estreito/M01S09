﻿using M01S09.Aula02.Models.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M01S09.Aula02.Models
{
    public class LojaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<PromocaoProduto> PromocoesProduto { get; set; }


        //public LojaContexto(DbContextOptions<LojaContexto> options) : base(options)
        //{

        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=LAPTOP-S276V0UN\\SQLEXPRESS;User ID=sa;Password=****;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompraConfiguration());
            modelBuilder.ApplyConfiguration(new PromocaoProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}

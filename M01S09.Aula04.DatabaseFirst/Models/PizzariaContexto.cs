using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace M01S09.Aula04.DatabaseFirst.Models;

public partial class PizzariaContexto : DbContext
{

    private static string scaffoldcommad = $"Scaffold-DbContext \"Data Source=LAPTOP-S276V0UN\\SQLEXPRESS;Database=Pizzaria;User Id=sa;Password=****;Trusted_Connection=False;Encrypt=False;Trust Server Certificate=False\" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -f -Context PizzariaContexto";
    public PizzariaContexto()
    {
    }

    public PizzariaContexto(DbContextOptions<PizzariaContexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Borda> Bordas { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabore> Sabores { get; set; }

    public virtual DbSet<StatusPizza> StatusPizzas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-S276V0UN\\SQLEXPRESS;Database=Pizzaria;User Id=sa;Password=****;Trusted_Connection=False;Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Borda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bordas__3214EC07AA084E04");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Massas__3214EC07DA4D124A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pedido__3214EC075571F628");

            entity.ToTable("Pedido");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza).HasColumnName("Id_Pizza");
            entity.Property(e => e.IdStatus).HasColumnName("Id_Status");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdPizza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Pizza");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.IdStatus)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_Status_Pizza");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza__3214EC072A263AE5");

            entity.ToTable("Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdBordas).HasColumnName("Id_Bordas");
            entity.Property(e => e.IdMassa).HasColumnName("Id_Massa");

            entity.HasOne(d => d.IdBordasNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdBordas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pizza_Bordas");

            entity.HasOne(d => d.IdMassaNavigation).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.IdMassa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pizza_Massas");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pizza_Sa__3214EC07B0C18025");

            entity.ToTable("Pizza_Sabores");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdPizza).HasColumnName("Id_Pizza");
            entity.Property(e => e.IdSabores).HasColumnName("Id_Sabores");

            entity.HasOne(d => d.IdPizzaNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdPizza)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pizza_Sabores_Pizza");

            entity.HasOne(d => d.IdSaboresNavigation).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.IdSabores)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pizza_Sabores_Sabores");
        });

        modelBuilder.Entity<Sabore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sabores__3214EC07B2809D21");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        modelBuilder.Entity<StatusPizza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Status_P__3214EC07613212AC");

            entity.ToTable("Status_Pizza");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nome)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("NOME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

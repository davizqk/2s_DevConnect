using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    public virtual DbSet<VwUsuarioPublicacoes> VwUsuarioPublicacoes { get; set; }

    public virtual DbSet<VwUsuarioPublicacoess> VwUsuarioPublicacoess { get; set; }

    public virtual DbSet<VwUsuarioPublicacoesss> VwUsuarioPublicacoesss { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_SA");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__tb_comen__1BA6C6F4883745EC");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_pu__5BE2A6F2");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_us__5AEE82B9");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.IdCurtida).HasName("PK__tb_curti__0AC033CA8BA120DC");

            entity.HasOne(d => d.IdPublicacaoNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_pu__5812160E");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_us__571DF1D5");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.IdPublicacao).HasName("PK__tb_publi__EA81BC3A197DAE55");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__5441852A");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__tb_usuar__4E3E04ADC091676F");

            entity.HasMany(d => d.IdUsuarioSeguido).WithMany(p => p.IdUsuarioSeguir)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17F790F9"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17036CC0"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguido").HasName("PK__tb_segui__EFA87AC167913FB3");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_usuario_seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_usuario_seguido");
                    });

            entity.HasMany(d => d.IdUsuarioSeguir).WithMany(p => p.IdUsuarioSeguido)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidor",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguir")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17036CC0"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguido")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__17F790F9"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguir", "IdUsuarioSeguido").HasName("PK__tb_segui__EFA87AC167913FB3");
                        j.ToTable("tb_seguidor");
                        j.IndexerProperty<int>("IdUsuarioSeguir").HasColumnName("id_usuario_seguir");
                        j.IndexerProperty<int>("IdUsuarioSeguido").HasColumnName("id_usuario_seguido");
                    });
        });

        modelBuilder.Entity<VwUsuarioPublicacoes>(entity =>
        {
            entity.ToView("vw_usuario_publicacoes");
        });

        modelBuilder.Entity<VwUsuarioPublicacoess>(entity =>
        {
            entity.ToView("vw_usuario_publicacoess");
        });

        modelBuilder.Entity<VwUsuarioPublicacoesss>(entity =>
        {
            entity.ToView("vw_usuario_publicacoesss");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

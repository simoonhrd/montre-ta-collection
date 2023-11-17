using System;
using System.Collections.Generic;
using Api.MontreTaCollection.Data.Context.Contract;
using Api.MontreTaCollection.Data.Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Api.MontreTaCollection.Data.Entity;

public partial class MontreTaCollectionDBContext : DbContext, IMontreTaCollectionDBContext
{
    public MontreTaCollectionDBContext()
    {
    }

    public MontreTaCollectionDBContext(DbContextOptions<MontreTaCollectionDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<CaseMaterial> CaseMaterials { get; set; }

    public virtual DbSet<GlassMaterial> GlassMaterials { get; set; }

    public virtual DbSet<Api.MontreTaCollection.Data.Entity.Model.Model> Models { get; set; }

    public virtual DbSet<MovementType> MovementTypes { get; set; }

    public virtual DbSet<StrapMaterial> StrapMaterials { get; set; }

    public virtual DbSet<Watch> Watches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;user=root;database=montre_ta_collection;port=3306", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PRIMARY");

            entity.ToTable("brand");

            entity.Property(e => e.BrandId)
                .HasColumnType("int(11)")
                .HasColumnName("brand_id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
        });

        modelBuilder.Entity<CaseMaterial>(entity =>
        {
            entity.HasKey(e => e.CaseMaterialId).HasName("PRIMARY");

            entity.ToTable("case_material");

            entity.Property(e => e.CaseMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("case_material_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<GlassMaterial>(entity =>
        {
            entity.HasKey(e => e.GlassMaterialId).HasName("PRIMARY");

            entity.ToTable("glass_material");

            entity.Property(e => e.GlassMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("glass_material_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Api.MontreTaCollection.Data.Entity.Model.Model>(entity =>
        {
            entity.HasKey(e => e.ModelId).HasName("PRIMARY");

            entity.ToTable("model");

            entity.HasIndex(e => e.BrandId, "brand_id");

            entity.Property(e => e.ModelId)
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.BrandId)
                .HasColumnType("int(11)")
                .HasColumnName("brand_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");

            entity.HasOne(d => d.Brand).WithMany(p => p.Models)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("model_ibfk_1");
        });

        modelBuilder.Entity<MovementType>(entity =>
        {
            entity.HasKey(e => e.MovementId).HasName("PRIMARY");

            entity.ToTable("movement_type");

            entity.Property(e => e.MovementId)
                .HasColumnType("int(11)")
                .HasColumnName("movement_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<StrapMaterial>(entity =>
        {
            entity.HasKey(e => e.StrapMaterialId).HasName("PRIMARY");

            entity.ToTable("strap_material");

            entity.Property(e => e.StrapMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("strap_material_id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Watch>(entity =>
        {
            entity.HasKey(e => e.WatchId).HasName("PRIMARY");

            entity.ToTable("watch");

            entity.HasIndex(e => e.CaseMaterialId, "case_material_id");

            entity.HasIndex(e => e.GlassMaterialId, "glass_material_id");

            entity.HasIndex(e => e.ModelId, "model_id");

            entity.HasIndex(e => e.MovementId, "movement_id");

            entity.HasIndex(e => e.StrapMaterialId, "strap_material_id");

            entity.Property(e => e.WatchId)
                .HasColumnType("int(11)")
                .HasColumnName("watch_id");
            entity.Property(e => e.CaseMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("case_material_id");
            entity.Property(e => e.GlassMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("glass_material_id");
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("image_url");
            entity.Property(e => e.ModelId)
                .HasColumnType("int(11)")
                .HasColumnName("model_id");
            entity.Property(e => e.MovementId)
                .HasColumnType("int(11)")
                .HasColumnName("movement_id");
            entity.Property(e => e.ProductionDate)
                .HasColumnType("year(4)")
                .HasColumnName("production_date");
            entity.Property(e => e.StrapMaterialId)
                .HasColumnType("int(11)")
                .HasColumnName("strap_material_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.CaseMaterial).WithMany(p => p.Watches)
                .HasForeignKey(d => d.CaseMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("watch_ibfk_1");

            entity.HasOne(d => d.GlassMaterial).WithMany(p => p.Watches)
                .HasForeignKey(d => d.GlassMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("watch_ibfk_5");

            entity.HasOne(d => d.Model).WithMany(p => p.Watches)
                .HasForeignKey(d => d.ModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("watch_ibfk_3");

            entity.HasOne(d => d.Movement).WithMany(p => p.Watches)
                .HasForeignKey(d => d.MovementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("watch_ibfk_2");

            entity.HasOne(d => d.StrapMaterial).WithMany(p => p.Watches)
                .HasForeignKey(d => d.StrapMaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("watch_ibfk_4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

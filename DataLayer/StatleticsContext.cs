using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using BusinessLayer;
namespace DataLayer;

public partial class StatleticsContext : DbContext
{
    public StatleticsContext()
    {
    }

    public StatleticsContext(DbContextOptions<StatleticsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Discipline> Disciplines { get; set; }

    public virtual DbSet<RunningRecord> RunningRecords { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server= 127.0.0.1;Database=statletics;User Id=root;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("categories");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(60);
        });

        modelBuilder.Entity<Discipline>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("disciplines");

            entity.HasIndex(e => e.IdCategory, "FK_Cat_disc");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.IdCategory)
                .HasColumnType("int(11)")
                .HasColumnName("ID_Category");
            entity.Property(e => e.Name).HasMaxLength(60);

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Disciplines)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Cat_disc");
        });

        modelBuilder.Entity<RunningRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("running_records");

            entity.HasIndex(e => e.IdDiscipline, "ID_Discipline");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("ID");
            entity.Property(e => e.ActivityType)
                .HasMaxLength(60)
                .HasDefaultValueSql("'NULL'");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.HasSpikes).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.IdDiscipline)
                .HasColumnType("int(11)")
                .HasColumnName("ID_Discipline");
            entity.Property(e => e.IsOutdoor).HasDefaultValueSql("'NULL'");
            entity.Property(e => e.Result).HasColumnType("time");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

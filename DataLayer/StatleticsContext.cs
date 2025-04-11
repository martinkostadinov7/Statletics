using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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

    public virtual DbSet<Athlete> Athletes { get; set; }

    public virtual DbSet<Run> Runs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server= 127.0.0.1;Database=statletics;User Id=root;Password=root");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Athlete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("athletes");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Club)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("club");
            entity.Property(e => e.DateOfBirth)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("date")
                .HasColumnName("date_of_birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasColumnType("enum('male','female')")
                .HasColumnName("gender");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("last_name");
            entity.Property(e => e.Notes)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("notes");
        });

        modelBuilder.Entity<Run>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("runs");

            entity.HasIndex(e => e.AthleteId, "athlete_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.AthleteId)
                .HasColumnType("int(11)")
                .HasColumnName("athlete_id");
            entity.Property(e => e.Date)
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Distance)
                .HasColumnType("int(11)")
                .HasColumnName("distance");
            entity.Property(e => e.IsHandTimed).HasColumnName("is_hand_timed");
            entity.Property(e => e.Notes)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Repetition)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("repetition");
            entity.Property(e => e.RestBetween)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("time")
                .HasColumnName("rest_between");
            entity.Property(e => e.Shoes)
                .HasMaxLength(50)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("shoes");
            entity.Property(e => e.TimeSeconds).HasColumnName("time_seconds");
            entity.Property(e => e.TotalRepetitions)
                .HasDefaultValueSql("'NULL'")
                .HasColumnType("int(11)")
                .HasColumnName("total_repetitions");

            entity.HasOne(d => d.Athlete).WithMany(p => p.Runs)
                .HasForeignKey(d => d.AthleteId)
                .HasConstraintName("runs_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

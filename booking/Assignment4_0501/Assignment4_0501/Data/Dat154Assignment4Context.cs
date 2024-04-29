using System;
using System.Collections.Generic;
using Assignment4_0501.Models;
using Microsoft.EntityFrameworkCore;
using Task = Assignment4_0501.Models.Task;

namespace Assignment4_0501.Data;

public partial class Dat154Assignment4Context : DbContext
{
    public Dat154Assignment4Context()
    {
    }

    public Dat154Assignment4Context(DbContextOptions<Dat154Assignment4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:haralds-server.database.windows.net,1433;Initial Catalog=dat154_assignment4;Persist Security Info=False;User ID=harald1337;Password=RemyMonsen123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Mobile).HasName("PK__customer__A32E2E1DE3CC3E7C");

            entity.ToTable("customer");

            entity.Property(e => e.Mobile)
                .ValueGeneratedNever()
                .HasColumnName("mobile");
            entity.Property(e => e.Fname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("fname");
            entity.Property(e => e.Lname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("lname");
            entity.Property(e => e.Pass)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pass");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3213E83F5C32F884");

            entity.ToTable("employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Emptype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("emptype");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__reservat__3213E83F437D341C");

            entity.ToTable("reservation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Checkin)
                .HasColumnType("date")
                .HasColumnName("checkin");
            entity.Property(e => e.Checkout)
                .HasColumnType("date")
                .HasColumnName("checkout");
            entity.Property(e => e.CustomerId).HasColumnName("customerID");
            entity.Property(e => e.RoomNum).HasColumnName("roomNum");

            entity.HasOne(d => d.Customer).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__reservati__custo__619B8048");

            entity.HasOne(d => d.RoomNumNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.RoomNum)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__reservati__roomN__628FA481");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomNum).HasName("PK__room__EEB9E32CF95EC4EC");

            entity.ToTable("room");

            entity.Property(e => e.RoomNum)
                .ValueGeneratedNever()
                .HasColumnName("roomNum");
            entity.Property(e => e.ImageLink)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NumBeds).HasColumnName("numBeds");
            entity.Property(e => e.RoomSize)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("roomSize");
            entity.Property(e => e.RoomStatus)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValueSql("('AVAILABLE')")
                .HasColumnName("roomStatus");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tasks__3213E83FD54E8088");

            entity.ToTable("tasks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoomNum).HasColumnName("roomNum");
            entity.Property(e => e.Taskdescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("taskdescription");
            entity.Property(e => e.Taskstatus)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("taskstatus");
            entity.Property(e => e.Tasktype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tasktype");

            entity.HasOne(d => d.RoomNumNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.RoomNum)
                .HasConstraintName("FK__tasks__roomNum__6754599E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

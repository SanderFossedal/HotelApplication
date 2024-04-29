
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FrontDeskWinForm.Models;

    public partial class Context : DbContext
    {
        public Context() { }

        public Context(DbContextOptions<Context> options) : base(options) { }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Employe> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=tcp:haralds-server.database.windows.net,1433;Initial Catalog=dat154_assignment4;" +
                "Persist Security Info=False;" +
                "User ID=harald1337;Password=RemyMonsen123!;MultipleActiveResultSets=False;" +
                "Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Mobile);
            entity.Property(e => e.FirstName).HasColumnName("fname");
            entity.Property(e => e.LastName).HasColumnName("lname");
            entity.Property(e => e.Password).HasColumnName("pass");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.RoomID);
            entity.Property(e => e.RoomID).HasColumnName("roomNum");
            entity.Property(e => e.RoomStatus).HasColumnName("roomStatus");
            entity.Property(e => e.BedsNumber).HasColumnName("numBeds");
            entity.Property(e => e.RoomSize).HasColumnName("roomSize");
        });

        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.CheckIn).HasColumnName("checkin");
            entity.Property(e => e.CheckOut).HasColumnName("checkout");
            entity.HasOne(e => e.CustomerId).WithMany().HasForeignKey("customerID");
            entity.HasOne(e => e.RoomId).WithMany().HasForeignKey("roomNum");
        });

        modelBuilder.Entity<Employe>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.EmployeType).HasColumnName("emptype");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.TaskType).HasColumnName("tasktype");
            entity.Property(e => e.TaskDescription).HasColumnName("taskdescription");
            entity.Property(e => e.TaskStatus).HasColumnName("taskstatus");
            entity.Property(e => e.TaskNote).HasColumnName("Note");
            entity.HasOne(e => e.RoomId).WithMany().HasForeignKey("roomNum");
        });
    }
    }


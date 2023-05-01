using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ticket_Blaster.Pages.DataDB
{
    public partial class TicketBlasterContext : DbContext
    {
        public TicketBlasterContext()
        {
        }

        public TicketBlasterContext(DbContextOptions<TicketBlasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BuildVersion> BuildVersions { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerTicket> CustomerTickets { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<Owner> Owners { get; set; } = null!;
        public virtual DbSet<Ticket> Tickets { get; set; } = null!;
        public virtual DbSet<Venue> Venues { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ticketblaster89.database.windows.net;Database=TicketBlaster;Trusted_Connection=False;User ID=TBadmin;Password=MacroHard123!!");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId)
                    .HasName("PK__BuildVer__35E58ECA357DCC2F");

                entity.ToTable("BuildVersion");

                entity.Property(e => e.SystemInformationId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SystemInformationID");

                entity.Property(e => e.DatabaseVersion)
                    .HasMaxLength(25)
                    .HasColumnName("Database Version");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VersionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerTicket>(entity =>
            {
                entity.HasKey(e => e.CustTicketId);

                entity.ToTable("CustomerTicket");

                entity.Property(e => e.CustTicketId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustTicketID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerTickets)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("Customer Owns Ticket");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.CustomerTickets)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("Event Has Ticket");
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.ToTable("ErrorLog");

                entity.Property(e => e.ErrorLogId).HasColumnName("ErrorLogID");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(126);

                entity.Property(e => e.ErrorTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName).HasMaxLength(128);
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("Owner");

                entity.Property(e => e.OwnerId)
                    .ValueGeneratedNever()
                    .HasColumnName("OwnerID");

                entity.Property(e => e.OwnerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OwnerFIrstName");

                entity.Property(e => e.OwnerLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OwnerPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketId)
                    .ValueGeneratedNever()
                    .HasColumnName("TicketID");

                entity.Property(e => e.TicketCost).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TicketDate).HasColumnType("date");

                entity.Property(e => e.TicketEvent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Venue)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.VenueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Venue has Event Tickets");
            });

            modelBuilder.Entity<Venue>(entity =>
            {
                entity.ToTable("Venue");

                entity.Property(e => e.VenueId)
                    .ValueGeneratedNever()
                    .HasColumnName("VenueID");

                entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

                entity.Property(e => e.VenueAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenueName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenuePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Venues)
                    .HasForeignKey(d => d.OwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Owner Owns Venue");
            });

            modelBuilder.HasSequence<int>("SalesOrderNumber", "SalesLT");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

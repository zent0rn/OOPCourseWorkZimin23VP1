using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.VisualBasic.Devices;
using Microsoft.EntityFrameworkCore;
using OOPCourseWorkZimin23VP1.entities;

namespace OOPCourseWorkZimin23VP1
{
    public class FurnitureDBContext : DbContext
    {
        public DbSet<Client> Client { get; set; } = null!;
        public DbSet<Furniture> Furniture { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrderItems { get; set; } = null!;
        public DbSet<Room> Room { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Укажите строку подключения к SQLite
            string _connString = "D:\\Learning\\OOPCourseProjectWork23VP1\\OOPDataBase\\FurnitureDB.db";
            optionsBuilder.UseSqlite($"Data Source={_connString}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Конфигурация связей и ограничений
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Room>().ToTable("Room");
            // Настройка первичных ключей
            modelBuilder.Entity<Client>().HasKey(c => c.ID);
            modelBuilder.Entity<Furniture>().HasKey(f => f.ID);
            modelBuilder.Entity<Order>().HasKey(o => o.ID);
            modelBuilder.Entity<OrderItem>().HasKey(oi => oi.ID);
            modelBuilder.Entity<Room>().HasKey(r => r.ID);

            // Настройка связей
            modelBuilder.Entity<Order>()
                .HasMany(o => o.Items)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.Order_ID);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Furniture)
                .WithMany()
                .HasForeignKey(oi => oi.Furniture_ID);

            modelBuilder.Entity<Furniture>()
                .HasOne(f => f.Room)
                .WithMany(r => r.FurnitureItems)
                .HasForeignKey(f => f.Room_ID);
            
        }
    }
}

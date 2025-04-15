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
       
        public DbSet<Furniture> Furniture { get; set; } = null!;
        
        public DbSet<Room> Room { get; set; } = null!;

        public DbSet<ResponsiblePerson> ResponsiblePerson { get; set; } = null!;

        public DbSet<FurnitureCondition> FurnitureCondition { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Укажите строку подключения к SQLite
            string _connString = "D:\\Learning\\OOPCourseProjectWork23VP1\\OOPDataBase\\FurnitureDB.db";
            optionsBuilder.UseSqlite($"Data Source={_connString}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Конфигурация связей и ограничений
            //modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Room>().ToTable("Room");

            modelBuilder.Entity<Furniture>().ToTable("Furniture");
            modelBuilder.Entity<ResponsiblePerson>().ToTable("ResponsiblePerson");

            modelBuilder.Entity<FurnitureCondition>().ToTable("FurnitureCondition");
            // Настройка первичных ключей
            
            modelBuilder.Entity<Furniture>().HasKey(f => f.ID);
            
            modelBuilder.Entity<Room>().HasKey(r => r.ID);

            modelBuilder.Entity<ResponsiblePerson>().HasKey(r => r.ID);

            modelBuilder.Entity<FurnitureCondition>().HasKey(f => f.ID);

            modelBuilder.Entity<Furniture>()
                .HasOne(f => f.Room)
                .WithMany()
                .HasForeignKey(f => f.Room_ID);

            modelBuilder.Entity<Room>()
               .HasOne(f => f.ResponsiblePerson)
               .WithMany()
               .HasForeignKey(f => f.Responsible_Person_ID);

            modelBuilder.Entity<FurnitureCondition>()
               .HasOne(f => f.Furniture)
               .WithMany()
               .HasForeignKey(f => f.Furniture_ID);

            
        }
    }
}

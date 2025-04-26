using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Microsoft.VisualBasic.Devices;
using Microsoft.EntityFrameworkCore;
using OOPCourseWorkZimin23VP1.entities;
using System.Data;
using System.Diagnostics;

namespace OOPCourseWorkZimin23VP1.dbServices
{
    /// <summary>
    /// Класс контекста базы данных ИС "мебель"
    /// </summary>
    public class FurnitureDBContext : DbContext
    {
       
        /// <summary>
        /// Таблица "Мебель"
        /// </summary>
        public DbSet<Furniture> Furniture { get; set; } = null!;
        
        /// <summary>
        /// Таблица "Помещения"
        /// </summary>
        public DbSet<Room> Room { get; set; } = null!;

        /// <summary>
        /// Таблица "Ответственные лица"
        /// </summary>
        public DbSet<ResponsiblePerson> ResponsiblePerson { get; set; } = null!;

        private string _connString;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FurnitureDBContext ()
        {
            _connString = Path.Combine(Directory.GetCurrentDirectory(), "OOPDataBase", "FurnitureDB.db");
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="dbPath">Путь к БД</param>
        public FurnitureDBContext (string dbPath)
        {
            _connString = dbPath;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            Debug.WriteLine($"DB Path: {_connString}");

            optionsBuilder.UseSqlite($"Data Source={_connString};Foreign Keys=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Конфигурация связей и ограничений
            //modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Room>().ToTable("Room");

            modelBuilder.Entity<Furniture>().ToTable("Furniture");

            modelBuilder.Entity<ResponsiblePerson>().ToTable("ResponsiblePerson");

            //modelBuilder.Entity<FurnitureCondition>().ToTable("FurnitureCondition");
            // Настройка первичных ключей
            
            modelBuilder.Entity<Furniture>().HasKey(f => f.ID);
            
            modelBuilder.Entity<Room>().HasKey(r => r.ID);

            modelBuilder.Entity<ResponsiblePerson>().HasKey(r => r.ID);

           // modelBuilder.Entity<FurnitureCondition>().HasKey(f => f.ID);

            modelBuilder.Entity<Furniture>()
                .HasOne(f => f.Room)
                .WithMany(r => r.Furniture)
                .HasForeignKey(f => f.Room_ID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room>()
               .HasOne(f => f.ResponsiblePerson)
               .WithMany(p => p.Rooms)
               .HasForeignKey(f => f.Responsible_Person_ID)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<ResponsiblePerson>()
                .HasMany(rp => rp.Rooms)
                .WithOne(r => r.ResponsiblePerson)
                .HasForeignKey(r => r.Responsible_Person_ID)
                .OnDelete(DeleteBehavior.Cascade);


           
        }

        /// <summary>
        /// Получить таблицу мебели
        /// </summary>
        /// <returns></returns>
        public DataTable GetFurnitureDataTable()
        {
            DataTable dt = new DataTable();

            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM Furniture";
                Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить таблицу помещений
        /// </summary>
        /// <returns></returns>
        public DataTable GetRoomDataTable()
        {
            DataTable dt = new DataTable();

            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM Room";
                Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }

        /// <summary>
        /// Получить таблицу ответственных лиц
        /// </summary>
        /// <returns></returns>
        public DataTable GetResponsiblePersonDataTable()
        {
            DataTable dt = new DataTable();

            using (var command = Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "SELECT * FROM ResponsiblePerson";
                Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    dt.Load(reader);
                }
            }

            return dt;
        }
    }
}

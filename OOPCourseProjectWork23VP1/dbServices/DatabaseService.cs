using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.dbServices
{
   /// <summary>
   /// Класс для работы с БД.
   /// </summary>
    public static class DatabaseService
    {
        private static string _currentDbPath;
        private static Func<FurnitureDBContext> _contextFactory;

        /// <summary>
        /// Инициализация базы данных
        /// </summary>
        /// <param name="dbPath">Путь к БД</param>
        public static void Initialize(string dbPath)
        {
            _currentDbPath = dbPath;

            // Настраиваем фабрику контекста
            _contextFactory = () => new FurnitureDBContext(dbPath);
        }

        /// <summary>
        /// Создание БД
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static FurnitureDBContext CreateContext() => _contextFactory?.Invoke()
            ?? throw new InvalidOperationException("Database not initialized!");
    }
}

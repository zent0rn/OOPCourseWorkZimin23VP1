using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.dbServices
{
    public static class DatabaseService
    {
        private static string _currentDbPath;
        private static Func<FurnitureDBContext> _contextFactory;

        public static void Initialize(string dbPath)
        {
            _currentDbPath = dbPath;

            // Настраиваем фабрику контекста
            _contextFactory = () => new FurnitureDBContext(dbPath);
        }

        public static FurnitureDBContext CreateContext() => _contextFactory?.Invoke()
            ?? throw new InvalidOperationException("Database not initialized!");
    }
}

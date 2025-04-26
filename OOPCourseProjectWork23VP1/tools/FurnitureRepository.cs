using Microsoft.EntityFrameworkCore;
using OOPCourseWorkZimin23VP1.dbServices;
using OOPCourseWorkZimin23VP1.entities;

namespace OOPCourseWorkZimin23VP1.tools
{
    /// <summary>
    /// Репозиторий мебели. Для взаимодействия с таблицей мебели.
    /// </summary>
    class FurnitureRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        /// <summary>
        /// Конструктор. Создания контекста БД.
        /// </summary>
        public FurnitureRepository()
        {
            _db = DatabaseService.CreateContext();
        }

        /// <summary>
        /// Получить контекст БД.
        /// </summary>
        /// <returns>Контекст БД</returns>
        public FurnitureDBContext getDb()
        {
            return _db;
        }
        /// <summary>
        /// Добавить мебель в БД.
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="type">Тип</param>
        /// <param name="material">Материал</param>
        /// <param name="madeby">Страна производства</param>
        /// <param name="price">Цена</param>
        /// <param name="valueInRoom">Количество в комнате</param>
        /// <param name="roomId">ID комнаты</param>
        public void AddFurniture(string name, string type, string material, string madeby, int price, int valueInRoom, int roomId)
        {
            var furniture = new Furniture
            {
                Name = name,
                Type = type,
                Material = material,
                MadeByCountry = madeby,
                Price = price,
                ValueInRoom = valueInRoom,
                Room_ID = roomId
            };

            _db.Furniture.Add(furniture);
            _db.SaveChanges();
        }
        
        /// <summary>
        /// Редактировать мебель.
        /// </summary>
        /// <param name="id">ID для редактирования</param>
        /// <param name="name">Новое имя</param>
        /// <param name="type">Тип мебели</param>
        /// <param name="material">Материал мебели</param>
        /// <param name="madeby">Страна производства мебели</param>
        /// <param name="price">Цена</param>
        /// <param name="valueInRoom">Количество в комнате</param>
        /// <param name="roomId">ID комнаты</param>
        /// <returns>true в случае успеха, false в случае неудачи</returns>
        public bool EditFurniture(int id, string name, string type, string material, 
            string madeby, int price, int valueInRoom, int roomId)
        {

            _db.ChangeTracker.Clear();
            var furniture = _db.Furniture.Find(id);

            if (furniture == null) return false;

            furniture.Name = name;
            furniture.Type = type;
            furniture.Material = material;
            furniture.MadeByCountry = madeby;
            furniture.Price = price;
            furniture.ValueInRoom = valueInRoom;
            furniture.Room_ID = roomId;

            _db.SaveChanges();

            

            return true;
        }

        /// <summary>
        /// Удалить мебель
        /// </summary>
        /// <param name="id">ID удаляемой мебели</param>
        /// <returns></returns>
        public bool DeleteFurniture(int id)
        {
            var furniture = _db.Furniture.Find(id);
            if (furniture != null)
            {
                _db.Furniture.Remove(furniture);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Найти мебель
        /// </summary>
        /// <param name="name">Имя</param>
        /// <param name="type">Тип</param>
        /// <param name="material">Материал</param>
        /// <param name="manufacturer">Страна производитель</param>
        /// <param name="roomID">ID комнаты</param>
        /// <returns>Список мебели</returns>
        public List<Furniture> SearchFurniture(string name = null, string type = null,
                                      string material = null, string manufacturer = null,
                                      int roomID = 0)
        {
            _db.ChangeTracker.Clear();
            // Начинаем с базового запроса
            IQueryable<Furniture> query = _db.Furniture
            .Include(f => f.Room) // Загружаем связанные данные
            .AsNoTracking();

            // Добавляем условия только если параметры не пустые
            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(f => f.Name.Contains(name));

            if (!string.IsNullOrWhiteSpace(type))
                query = query.Where(f => f.Type.Contains(type));

            if (!string.IsNullOrWhiteSpace(material))
                query = query.Where(f => f.Material.Contains(material));

            if (!string.IsNullOrWhiteSpace(manufacturer))
                query = query.Where(f => f.MadeByCountry.Contains(manufacturer));

            if (roomID != 0)
                query = query.Where(f => f.Room_ID.Equals(roomID)); // Name.Contains(room);

            //query = SortFurniture(query, sortBy, ascending);

            return query.ToList();

            
        }

        /// <summary>
        /// Метод для сортировки мебели
        /// </summary>
        /// <param name="query">Очередь</param>
        /// <param name="sortBy">Сортировать по</param>
        /// <param name="ascending">Возрастающий или убывающий порядок</param>
        /// <returns></returns>
        private IQueryable<Furniture> SortFurniture(IQueryable<Furniture> query, string sortBy, bool ascending)
    {
            switch (sortBy)
            {
                case "Name":
                    query = ascending ? query.OrderBy(f => f.Name) : query.OrderByDescending(f => f.Name);
                    return query;
                case "MadeBy":
                    query = ascending ? query.OrderBy(f => f.MadeByCountry) : query.OrderByDescending(f => f.MadeByCountry);
                    return query;
                case "Type":
                    query = ascending ? query.OrderBy(f => f.Type) : query.OrderByDescending(f => f.Type);
                    return query;
                case "Material":
                    query = ascending ? query.OrderBy(f => f.Material) : query.OrderByDescending(f => f.Material);
                    return query;
                case "Room":
                    query = ascending ?
                        query.OrderBy(f => f.Room_ID) :
                        query.OrderByDescending(f => f.Room_ID);
                    return query;
                case "Price":
                    query = ascending ? query.OrderBy(f => (int)f.Price) : query.OrderByDescending(f => (int)f.Price);
                    return query;
                case "ValueInRoom":
                    query = ascending ? query.OrderBy(f => f.ValueInRoom) : query.OrderByDescending(f => f.ValueInRoom);
                    return query;
                default:
                    query = query.OrderBy(f => f.Name);
                    return query;
            }
        }

        /// <summary>
        /// Метод для обновления контекста после редактирования
        /// </summary>
        public void RefreshContext()
        {
            // Отсоединяем все отслеживаемые объекты
            var changedEntriesCopy = _db.ChangeTracker.Entries()
                .Where(e => e.State is (Microsoft.EntityFrameworkCore.EntityState)EntityState.Added or
                            (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified or
                            (Microsoft.EntityFrameworkCore.EntityState)EntityState.Deleted)
                .ToList();

            foreach (var entry in changedEntriesCopy)
                entry.State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Detached;
        }


        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

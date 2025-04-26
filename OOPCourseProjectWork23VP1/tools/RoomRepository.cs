using OOPCourseWorkZimin23VP1.dbServices;
using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.tools
{
    /// <summary>
    /// Репозиторий помещений. 
    /// Для взаимодействия с таблицей помещений.
    /// </summary>
    class RoomRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        /// <summary>
        /// Конструктор. Иниализируется контекст БД.
        /// </summary>
        public RoomRepository ()
        {
            _db = DatabaseService.CreateContext();
        }

        /// <summary>
        /// Получить контекст БД.
        /// </summary>
        /// <returns>контекст БД</returns>
        public FurnitureDBContext getDb()
        {
            return _db;
        }

        /// <summary>
        /// Получить данные о помещениях в виде списка.
        /// </summary>
        /// <returns></returns>
        public List<Room> LoadData()
        {
            return _db.Room.ToList();
        }
        
        /// <summary>
        /// Найти помещение по критериям
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="adress">Адрес</param>
        /// <param name="area">Площадь</param>
        /// <param name="ResponsiblePerson_ID">ID ответственного лица</param>
        /// <returns>Список помещение</returns>
        public List<Room> SearchRooms(string name = null, string adress = null,
                                      int area = 0, int ResponsiblePerson_ID = 0)
        {
            _db.ChangeTracker.Clear();
            // Начинаем с базового запроса
            IQueryable<Room> query = _db.Room
                .AsNoTracking();


            // Добавляем условия только если параметры не пустые
            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(f => f.Name.Contains(name));

            if (!string.IsNullOrWhiteSpace(adress))
                query = query.Where(f => f.Adress.Contains(adress));

            if (area != 0)
                query = query.Where(f => f.Area.Equals(area));

            if (ResponsiblePerson_ID != 0)
                query = query.Where(f => f.Responsible_Person_ID.Equals(ResponsiblePerson_ID)); 

            return query.ToList();


        }

        /// <summary>
        /// Добавить помещение
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="adress">Адрес</param>
        /// <param name="area">Площадь</param>
        /// <param name="respPersonID">ID ответственного лица</param>
        /// <returns>true в случае успеха, иначе - false</returns>
        public bool AddRoom(string name, string adress, int area, int respPersonID)
        {
            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(adress) &&
                !string.IsNullOrWhiteSpace(name) &&
                respPersonID > 0)
            {
                Room room = new Room
                {
                    Name = name,
                    Adress = adress,
                    Area = area,
                    Responsible_Person_ID = respPersonID
                };

                _db.Room.Add(room);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Удалить помещение
        /// </summary>
        /// <param name="id">ID помещения для удаления</param>
        /// <returns>true в случае успеха, иначе - false </returns>
        public bool DeleteRoom(int id)
        {
            // Загружаем комнату вместе с мебелью
            var room = _db.Room
                .Include(r => r.Furniture) // Явная загрузка
                .FirstOrDefault(r => r.ID == id);

            if (room != null)
            {
                // Удаляем мебель, если она есть
                if (room.Furniture != null && room.Furniture.Any())
                {
                    _db.Furniture.RemoveRange(room.Furniture);
                }

                _db.Room.Remove(room);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Редактировать помещение
        /// </summary>
        /// <param name="id">ID редактируемого помещения</param>
        /// <param name="name">Название</param>
        /// <param name="address">Адрес</param>
        /// <param name="area">Площадь</param>
        /// <param name="personId">ID ответственного лица</param>
        /// <returns>true в случае успеха, иначе - false</returns>
        public bool EditRoom(int id, string name, string address, int area, int personId)
        {
            _db.ChangeTracker.Clear();
            var room = _db.Room.Find(id);

            if (room == null) return false;

            room.Name = name;
            room.Adress = address;
            room.Area = area;
            room.Responsible_Person_ID = personId;

            _db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

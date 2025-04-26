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
    class RoomRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        public RoomRepository ()
        {
            _db = DatabaseService.CreateContext();
        }

        public FurnitureDBContext getDb()
        {
            return _db;
        }

        public List<Room> LoadData()
        {
            return _db.Room.ToList();
        }

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
                query = query.Where(f => f.Responsible_Person_ID.Equals(ResponsiblePerson_ID)); // Name.Contains(room);

            //query = SortRooms(query, sortBy, ascending);

            return query.ToList();


        }

        
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

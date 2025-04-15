using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
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
            _db = new FurnitureDBContext();
            _db.Database.EnsureCreated();
        }

        public List<Room> LoadData()
        {
            return _db.Room.ToList();
        }

        public List<Room> SearchRooms(string name = null, string adress = null,
                                      int area = 0, int ResponsiblePerson_ID = 0)
        {

            // Начинаем с базового запроса
            IQueryable<Room> query = _db.Room;
            

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

        /*
        private IQueryable<Room> SortRooms(IQueryable<Room> query, string sortBy, bool ascending)
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
        */
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

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

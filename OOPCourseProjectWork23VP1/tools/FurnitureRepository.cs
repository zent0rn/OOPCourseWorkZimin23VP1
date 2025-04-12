using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace OOPCourseWorkZimin23VP1.tools
{
    class FurnitureRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        public FurnitureRepository()
        {
            _db = new FurnitureDBContext();
            _db.Database.EnsureCreated();
        }

        public List<Furniture> SearchAndSortFurniture(string name = null, string type = null,
                                      string material = null, string manufacturer = null,
                                      int roomID = 0, string sortBy = null, bool ascending = true)
        {
            
            // Начинаем с базового запроса
            IQueryable<Furniture> query = _db.Furniture;
            //.Include(f => f.Room); // Загружаем связанные данные

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

            query = SortFurniture(query, sortBy, ascending);

            return query.ToList();

            
        }

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


        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

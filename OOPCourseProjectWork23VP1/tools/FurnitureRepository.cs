using OOPCourseWorkZimin23VP1.entities;

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

        public FurnitureDBContext getDb()
        {
            return _db;
        }
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

        public bool EditFurniture(int id, string name, string type, string material, 
            string madeby, int price, int valueInRoom, int roomId)
        {
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


        public List<Furniture> SearchFurniture(string name = null, string type = null,
                                      string material = null, string manufacturer = null,
                                      int roomID = 0)
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

            //query = SortFurniture(query, sortBy, ascending);

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

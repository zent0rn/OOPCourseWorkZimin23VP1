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

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

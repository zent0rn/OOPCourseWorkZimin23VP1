using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.tools
{
    class ResponsiblePersonRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        public ResponsiblePersonRepository()
        {
            _db = new FurnitureDBContext();
            _db.Database.EnsureCreated();
        }

        public List<ResponsiblePerson> LoadData()
        {
            return _db.ResponsiblePerson.ToList();
        }

        public List<ResponsiblePerson> SearchPersons(string name = null, string phone = null, string email = null)
        {
            IQueryable<ResponsiblePerson> query = _db.ResponsiblePerson;

            if (!string.IsNullOrWhiteSpace(name))
            {
                query = query.Where(r => r.FullName.Contains(name));
            }
            if (!string.IsNullOrWhiteSpace(phone))
            {
                query = query.Where(r => r.Phone.Contains(phone));
            }

            if (!string.IsNullOrWhiteSpace(email))
            {
                query = query.Where(r => r.Email.Contains(email));
            }

            return query.ToList();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
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

        public FurnitureDBContext getDb()
        {
            return _db;
        }
        public List<ResponsiblePerson> LoadData()
        {
            return _db.ResponsiblePerson.ToList();
        }

        public List<ResponsiblePerson> SearchPersons(string name = null, string phone = null, string email = null)
        {
            _db.ChangeTracker.Clear();
            IQueryable<ResponsiblePerson> query = _db.ResponsiblePerson
                .AsNoTracking();

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

        public bool AddPerson(string name, string phone, string email)
        {
            if (!string.IsNullOrWhiteSpace(name) &&
                !string.IsNullOrWhiteSpace(phone) &&
                !string.IsNullOrWhiteSpace(email))
            {
                ResponsiblePerson Person = new ResponsiblePerson
                {
                    FullName = name,
                    Phone = phone,
                    Email = email
                };

                _db.ResponsiblePerson.Add(Person);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeletePerson(int id)
        {
            // Загружаем комнату вместе с мебелью
            var person = _db.ResponsiblePerson
                .Include(r => r.Rooms) // Явная загрузка
                .FirstOrDefault(r => r.ID == id);

            if (person != null)
            {
                // Удаляем мебель, если она есть
                if (person.Rooms != null && person.Rooms.Any())
                {
                    _db.Room.RemoveRange(person.Rooms);
                }

                _db.ResponsiblePerson.Remove(person);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool EditPerson(int id, string name, string phone, string email)
        {
            _db.ChangeTracker.Clear();
            var person = _db.ResponsiblePerson.Find(id);

            if (person == null) return false;

            person.FullName = name;
            person.Phone = phone;
            person.Email = email;

            _db.SaveChanges();
            return true;
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}

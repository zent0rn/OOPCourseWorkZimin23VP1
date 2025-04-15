
/*
using OOPCourseWorkZimin23VP1.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.tools
{
    class ClientRepository : IDisposable
    {
        private readonly FurnitureDBContext _db;

        public ClientRepository()
        {
            _db = new FurnitureDBContext();
            _db.Database.EnsureCreated();
        }

        public List<Client> SearchAndSortClients(string name = null, string phone = null,
                                        string address = null, string email = null, 
                                        int numbOfOrders = 0,
                                        string sortBy = null,
                                        bool ascending = true)
        {
            IQueryable<Client> query = _db.Client;

            // Фильтрация
            if (!string.IsNullOrWhiteSpace(name))
                query = query.Where(c => c.Name.Contains(name));
            if (!string.IsNullOrWhiteSpace(phone))
                query = query.Where(c => c.PhoneNumber.Contains(phone));

            if (!string.IsNullOrWhiteSpace(address))
                query = query.Where(c => c.Address.Contains(address));
            if (!string.IsNullOrWhiteSpace(email))
                query = query.Where(c => c.Email.Contains(email));
            if (numbOfOrders != 0)
                query = query.Where(c => c.NumbOfOrders.Equals(numbOfOrders));

            // Сортировка
            query = SortClients(query, sortBy, ascending);

            return query.ToList();
        }

        private IQueryable<Client> SortClients(IQueryable<Client> query, string sortBy, bool ascending)
        {
            switch (sortBy)
            {
                case "Name":
                    return ascending ? query.OrderBy(c => c.Name) : query.OrderByDescending(c => c.Name);
                case "Phone":
                    return ascending ? query.OrderBy(c => c.PhoneNumber) : query.OrderByDescending(c => c.PhoneNumber);
                case "Address":
                    return ascending ? query.OrderBy(c => c.Address) : query.OrderByDescending(c => c.Address);
                case "Email":
                    return ascending ? query.OrderBy(c => c.Email) : query.OrderByDescending(c => c.Email);
                case "NumbOfOrders":
                    return ascending ? query.OrderBy(c => c.NumbOfOrders) : query.OrderByDescending(c => c.NumbOfOrders);
                default:
                    return query.OrderBy(c => c.Name);
            }
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
*/
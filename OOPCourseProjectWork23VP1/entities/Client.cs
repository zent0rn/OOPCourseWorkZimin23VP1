using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class Client
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int NumbOfOrders { get; set; }

        public ICollection<Order> Orders { get; set; } = new List<Order>();

        // Конструктор по умолчанию
        public Client() { }

        // Конструктор с параметрами 
        public Client(int id, string name, string phoneNumber, string address, string email, int numbOfOrders)
        {
            ID = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            NumbOfOrders = numbOfOrders;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class Order
    {
        public int ID { get; set; }
        public int Client_ID { get; set; }
        public DateTime Date { get; set; }
        public decimal Total_Price { get; set; }


        public Client Client { get; set; }
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        // Конструктор по умолчанию
        public Order() { }

        // Конструктор с параметрами
        public Order(int id, int clientId, DateTime date, decimal totalPrice)
        {
            ID = id;
            Client_ID = clientId;
            Date = date;
            Total_Price = totalPrice;
        }
    }
}

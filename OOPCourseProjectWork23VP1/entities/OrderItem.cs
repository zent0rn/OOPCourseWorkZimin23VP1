using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int Order_ID { get; set; }
        public int Furniture_ID { get; set; }
        public int Quantity { get; set; }  // Value_Of_Furniture переименовано в Quantity
        public decimal TotalPrice { get; set; }

        public Order Order { get; set; }
        public Furniture Furniture { get; set; }

        // Конструктор по умолчанию
        public OrderItem() { }

        // Конструктор с параметрами
        public OrderItem(int orderId, int furnitureId, int quantity, decimal totalPrice)
        {
            Order_ID = orderId;
            Furniture_ID = furnitureId;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }

        // Метод для расчета стоимости
        public void CalculateTotalPrice(decimal unitPrice)
        {
            TotalPrice = unitPrice * Quantity;
        }

    }
}

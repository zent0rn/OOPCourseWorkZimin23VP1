using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class Furniture
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Material { get; set; }
        public string MadeByCountry { get; set; }
        public int Room_ID { get; set; }
        public decimal Price { get; set; }
        public int ValueInRoom { get; set; }


        public Room Room { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        // Конструктор по умолчанию
        public Furniture() { }

        // Конструктор с параметрами для удобного создания объектов
        public Furniture(int id, string name, string type, int material,
                       string madeByCountry, int roomId, decimal price, int valueInRoom)
        {
            ID = id;
            Name = name;
            Type = type;
            Material = material;
            MadeByCountry = madeByCountry;
            Room_ID = roomId;
            Price = price;
            ValueInRoom = valueInRoom;
        }

    }
}

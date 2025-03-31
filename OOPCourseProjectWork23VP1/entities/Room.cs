using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; } 
        public string ResponsiblePerson { get; set; }


        // Навигационное свойство
    public ICollection<Furniture> FurnitureItems { get; set; } = new List<Furniture>();

        // Конструктор по умолчанию
        public Room() { }

        // Конструктор с параметрами
        public Room(int id, string name, string address, string responsiblePerson)
        {
            ID = id;
            Name = name;
            Address = address;
            ResponsiblePerson = responsiblePerson;
        }
    }
}

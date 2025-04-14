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
        public string Adress { get; set; } 
        public string Responsible_Person { get; set; }


        // Навигационное свойство
    public ICollection<Furniture> FurnitureItems { get; set; } = new List<Furniture>();

        // Конструктор по умолчанию
        public Room() { }

        // Конструктор с параметрами
        public Room(int id, string name, string adress, string responsiblePerson)
        {
            ID = id;
            Name = name;
            Adress = adress;
            Responsible_Person = responsiblePerson;
        }
    }
}

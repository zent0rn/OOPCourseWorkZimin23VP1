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

        public int Area { get; set; }
        public int Responsible_Person_ID { get; set; }

        public ResponsiblePerson ResponsiblePerson;
        
        // Конструктор по умолчанию
        public Room() { }

        // Конструктор с параметрами
        public Room(int id, string name, string adress, int area, int responsiblePersonID)
        {
            ID = id;
            Name = name;
            Adress = adress;
            Area = area;
            Responsible_Person_ID = responsiblePersonID;
        }
    }
}

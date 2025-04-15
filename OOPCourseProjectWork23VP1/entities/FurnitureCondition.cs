using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class FurnitureCondition
    {
        public int ID { get; set; }

        public int Furniture_ID { get; set; }

        public string[] Condition { get; } = ["Отличное", "Хорошее", "Удовлетворительное", "Плохое"];

        public string Notes { get; set; }

        public Furniture Furniture;
        public FurnitureCondition()
        {

        }

        public FurnitureCondition(int id, int furniture_ID, string notes)
        {
            ID = id;
            Furniture_ID = furniture_ID;
            Notes = notes;
        }



    }
}

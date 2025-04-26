using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    /// <summary>
    /// Класс для сущности помещение
    /// </summary>
    public class Room
    {
        /// <summary>
        /// ID помещения
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название помещения
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Адрес 
        /// </summary>
        public string Adress { get; set; } 

        /// <summary>
        /// Площадь помещения
        /// </summary>
        public int Area { get; set; }

        /// <summary>
        /// ID ответственного лица
        /// </summary>
        public int Responsible_Person_ID { get; set; }

        /// <summary>
        /// Ответственное лицо
        /// </summary>
        public ResponsiblePerson ResponsiblePerson { get; set; }

        /// <summary>
        /// Список мебели комнаты
        /// </summary>
        public List<Furniture> Furniture { get; set; }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Room() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="name">Название</param>
        /// <param name="adress">Адрес</param>
        /// <param name="area">Площадь</param>
        /// <param name="responsiblePersonID">ID ответственного лица</param>
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

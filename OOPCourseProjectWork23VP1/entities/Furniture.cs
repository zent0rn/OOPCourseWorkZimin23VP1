using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    /// <summary>
    /// Класс для сущности мебель
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Название 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Материал
        /// </summary>
        public string Material { get; set; }

        /// <summary>
        /// Страна производства
        /// </summary>
        public string MadeByCountry { get; set; }

        /// <summary>
        /// ID комнаты
        /// </summary>
        public int Room_ID { get; set; }

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Количество в комнате
        /// </summary>
        public int ValueInRoom { get; set; }

        /// <summary>
        /// Объект комнаты
        /// </summary>
        public Room Room { get; set; }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Furniture() { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">Название</param>
        /// <param name="type">Тип</param>
        /// <param name="material">Материал</param>
        /// <param name="madeByCountry">Страна производства</param>
        /// <param name="roomId">ID комнаты</param>
        /// <param name="price">Цена</param>
        /// <param name="valueInRoom">Количество в комнате</param>
        public Furniture(int id, string name, string type, string material,
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

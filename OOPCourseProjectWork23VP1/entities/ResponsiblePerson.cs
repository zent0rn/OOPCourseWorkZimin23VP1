using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    /// <summary>
    /// Класс для сущности ответственное лицо
    /// </summary>
    public class ResponsiblePerson
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Полное имя
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Почта
        /// </summary>
        public string Email {get; set;}

        /// <summary>
        /// Список комнат
        /// </summary>
        public List<Room> Rooms { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ResponsiblePerson()
        {

        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="fullName">Полное имя</param>
        /// <param name="phone">Телефон</param>
        /// <param name="email">Почта</param>
        public ResponsiblePerson(int id, string fullName, string phone, string email)
        {
            ID = id;
            FullName = fullName;
            Phone = phone;
            Email = email;
        }
    }
}

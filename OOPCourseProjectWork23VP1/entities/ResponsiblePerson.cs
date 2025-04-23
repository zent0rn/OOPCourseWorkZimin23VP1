using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCourseWorkZimin23VP1.entities
{
    public class ResponsiblePerson
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email {get; set;}

        public List<Room> Rooms { get; set; }
        public ResponsiblePerson()
        {

        }

        public ResponsiblePerson(int id, string fullName, string phone, string email)
        {
            ID = id;
            FullName = fullName;
            Phone = phone;
            Email = email;
        }
    }
}

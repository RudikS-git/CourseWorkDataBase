using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string NumberPhone { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
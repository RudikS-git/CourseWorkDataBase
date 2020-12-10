using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models.Accessory
{
    [Table("Liquid")]
    public class Liquid : Accessory, ICooling
    {
        public int Id { get; set; }
    }
}

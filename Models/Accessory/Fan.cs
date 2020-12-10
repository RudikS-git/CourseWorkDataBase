using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models.Accessory
{
    [Table("Fan")]
    public class Fan : Accessory, ICooling
    {
        public int Id { get; set; }
    }
}

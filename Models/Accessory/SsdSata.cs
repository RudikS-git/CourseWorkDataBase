﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models.Accessory
{
    [Table("SsdSata")]
    public class SsdSata : Accessory
    {
        public int Id { get; set; }
    }
}

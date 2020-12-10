using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models
{
    public class Keep
    {
        public int Id { get; set; }
        
        public int StorageId { get; set; }
        public Storage Storage { get; set; }

        public int AccessoryId { get; set; }
        public Accessory.Accessory Accessory { get; set; }

        public DateTime DateReceipts { get; set; }

        public int Count { get; set; }
    }
}

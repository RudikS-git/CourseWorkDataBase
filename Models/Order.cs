using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models
{
    public class Order
    {
        public int Id { get; set; }

        public Accessory.Accessory AccessoryId { get; set; }
        public Accessory.Accessory Accessory { get; set; }
        public int Count { get; set; }

        public DateTime Date { get; set; }
        public DateTime DateDelivery { get; set; }

        public string MethodOfObtaiting { get; set; }
    }
}

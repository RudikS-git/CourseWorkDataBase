using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models
{
    public class Belong
    {
        public int Id { get; set; }

        public int? FeatureId { get; set; }
        public Feature Feature { get; set; }

        public int AccessoryId { get; set; }
        public Accessory.Accessory Accessory { get; set; }

        public string Value { get; set; }
        public string Dimension { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkDataBase.Models
{
    public class Feature
    {
        public int Id { get; set; }
        public string Code { get; set; }

        public int? FeatureGroupId { get; set; }
        public FeatureGroup FeatureGroup { get; set; }

        public string Name { get; set; }
    }
}

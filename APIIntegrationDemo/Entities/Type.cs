using System;
using System.Collections.Generic;

namespace APIIntegrationDemo.Entities
{
    public partial class Type
    {
        public Type()
        {
            Attraction = new HashSet<Attraction>();
        }

        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeRef { get; set; }
        public string TypeIcon { get; set; }
        public string Template { get; set; }

        public virtual ICollection<Attraction> Attraction { get; set; }
    }
}

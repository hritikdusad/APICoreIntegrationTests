using System;
using System.Collections.Generic;

namespace APIIntegrationDemo.Entities
{
    public partial class Location
    {
        public Location()
        {
            Attraction = new HashSet<Attraction>();
        }

        public string LocationId { get; set; }
        public string ParentId { get; set; }
        public string LocationName { get; set; }
        public string LocationRef { get; set; }
        public string LocationTypeId { get; set; }

        public virtual ICollection<Attraction> Attraction { get; set; }
    }
}

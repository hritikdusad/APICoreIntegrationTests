using System;
using System.Collections.Generic;

namespace APIIntegrationDemo.Entities
{
    public partial class Attraction
    {
        public string AttractionId { get; set; }
        public string Title { get; set; }
        public bool? FastPass { get; set; }
        public bool? ChildFriendly { get; set; }
        public string LocationId { get; set; }
        public string Description { get; set; }
        public string NotesTips { get; set; }
        public decimal? Price { get; set; }
        public short? Rating { get; set; }
        public string TypeId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Type Type { get; set; }
    }
}

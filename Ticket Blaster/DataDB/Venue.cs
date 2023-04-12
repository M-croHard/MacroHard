using System;
using System.Collections.Generic;

namespace Ticket_Blaster.DataDB
{
    public partial class Venue
    {
        public Venue()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int VenueId { get; set; }
        public string VenueName { get; set; } = null!;
        public string VenueAddress { get; set; } = null!;
        public string VenuePhone { get; set; } = null!;
        public int OwnerId { get; set; }

        public virtual Owner Owner { get; set; } = null!;
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}

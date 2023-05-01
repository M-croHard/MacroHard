using System;
using System.Collections.Generic;

namespace Ticket_Blaster.Pages.DataDB
{
    public partial class Owner
    {
        public Owner()
        {
            Venues = new HashSet<Venue>();
        }

        public int OwnerId { get; set; }
        public string OwnerFirstName { get; set; } = null!;
        public string OwnerLastName { get; set; } = null!;
        public string OwnerPhone { get; set; } = null!;
        public string OwnerEmail { get; set; } = null!;

        public virtual ICollection<Venue> Venues { get; set; }
    }
}

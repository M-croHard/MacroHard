using System;
using System.Collections.Generic;

namespace Ticket_Blaster.Pages.DataDB
{
    public partial class Ticket
    {
        public Ticket()
        {
            CustomerTickets = new HashSet<CustomerTicket>();
        }

        public int TicketId { get; set; }
        public string TicketEvent { get; set; } = null!;
        public int VenueId { get; set; }
        public DateTime TicketDate { get; set; }
        public string TicketType { get; set; } = null!;
        public int TicketMax { get; set; }
        public int TicketAvailable { get; set; }
        public decimal TicketCost { get; set; }

        public virtual Venue Venue { get; set; } = null!;
        public virtual ICollection<CustomerTicket> CustomerTickets { get; set; }
    }
}

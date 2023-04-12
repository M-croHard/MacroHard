using System;
using System.Collections.Generic;

namespace Ticket_Blaster.DataDB
{
    public partial class CustomerTicket
    {
        public int CustTicketId { get; set; }
        public int? CustomerId { get; set; }
        public int? TicketId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Ticket? Ticket { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Ticket_Blaster.Pages.DataDB
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerTickets = new HashSet<CustomerTicket>();
        }

        public int CustomerId { get; set; }
        public string CustEmail { get; set; } = null!;
        public string CustUserName { get; set; } = null!;
        public string CustPassword { get; set; } = null!;
        public string CustFirstName { get; set; } = null!;
        public string CustLastName { get; set; } = null!;
        public string CustAddress { get; set; } = null!;
        public string CustPhone { get; set; } = null!;

        public virtual ICollection<CustomerTicket> CustomerTickets { get; set; }
    }
}

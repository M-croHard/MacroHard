using System;

namespace Event.Ticket_Blaster.Pages.Shared.App_code
{
    public class Event
    {
        // Properties
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string EventHost { get; set; }
        public DateTime EventDate { get; set; }
        public string EventAddress { get; set; }
        public int MaxPeople { get; set; }
        public int TicketsSold { get; set; }

        // Constructor
        public Event(int eventID, string eventName, string eventHost, DateTime eventDate, string eventAddress, int maxPeople)
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventHost = eventHost;
            this.EventDate = eventDate;
            this.EventAddress = eventAddress;
            this.MaxPeople = maxPeople;
        }

        public int ticketsLeft()
        {
            return MaxPeople - TicketsSold;
        }
    }
}

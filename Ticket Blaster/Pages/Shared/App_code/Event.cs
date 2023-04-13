using System;

namespace Event.Ticket_Blaster.Pages.Shared.App_code
{
    public class Event
    {
        //Attributes
        private int EventID;
        private string EventName;
        private string EventHost;
        private DateTime EventDate;
        private string EventAddress;
        private int MaxPeople;

        private int TicketsSold;

        //Methods
        protected int EventID { get; set; };
        protected string EventName { get; set; };
        protected string EventHost { get; set; };
        protected string EventDate { get; set; };
        protected string EventAddress { get; set; };
        protected int MaxPeople { get; set; };
        protected int TicketsSold { get; set; };

        public Event(int eventID, string eventName, string eventHost, DateTime eventDate, string, eventAddress, int maxPeople)          //constructor
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventHost = eventHost;
            this.EventDate = eventDate;
            this.EventAddress = eventAddress;
            this.MaxPeople = maxPeople;
        }

        public int ticketsLeft() {
            return MaxPeople - TicketsSold;
        };
    }
}

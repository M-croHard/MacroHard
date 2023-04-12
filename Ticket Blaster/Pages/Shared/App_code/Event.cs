using System;

namespace Event.Ticket_Blaster.Pages.Shared.App_code
{
    //Will interface with 
    public class Event
    {
        //Attributes
        private int EventID;
        private string EventName;
        private string EventHost;
        private DateTime EventDate;
        private string EventAddress;
        private int MaxPeople;

        //Methods
        protected int EventID { get; set; };
        protected string EventName { get; set; };
        protected string EventHost { get; set; };
        protected string EventDate { get; set; };
        protected string EventAddress { get; set; };
        protected int MaxPeople { get; set; };

        public Event(int eventID, string eventName, string eventHost, DateTime eventDate, string, eventAddress, int maxPeople)          //default constructor
        {
            this.EventID = eventID;
            this.EventName = eventName;
            this.EventHost = eventHost;
            this.EventDate = eventDate;
            this.EventAddress = eventAddress;
            this.MaxPeople = maxPeople;
        }
    }
}

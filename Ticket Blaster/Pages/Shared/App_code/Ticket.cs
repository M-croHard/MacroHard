namespace Ticket_Blaster.Pages.Shared.App_code
{
    public class Ticket
    {
        public int TicketId { get; }                                                               //properties
        public string EventName { get; }
        public decimal Price { get; }
        public bool IsAvailable { get; set; }

        public Ticket(int ticketId, string eventName, decimal price, bool isAvailable)            //constructor
        {
            TicketId = ticketId;
            EventName = eventName;
            Price = price;
            IsAvailable = isAvailable;
        }

        public void PurchaseTicket()                                                              //method to purchase a ticket
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Ticket ID: {TicketId} has been purchased for {EventName}.");
            }
            else
            {
                Console.WriteLine($"Ticket ID: {TicketId} is not available for purchase.");
            }
        }

        public void DisplayTicketInfo()                                                          //method to display ticket information
        {
            Console.WriteLine($"Ticket ID: {TicketId}");
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Sold Out")}");
        }
    }
}

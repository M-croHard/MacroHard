using Microsoft.DotNet.Scaffolding.Shared.CodeModifier.CodeChange;
using Microsoft.VisualBasic;
using System.Net.Sockets;
using System.Runtime.Intrinsics.X86;

namespace Ticket_Blaster.Pages.Shared.App_Code
{
    public class Ticket
    {
        // Properties
        public int TicketId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string Venue { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor
        public Ticket(int ticketId, string eventName, DateTime eventDate, string venue, decimal price, bool isAvailable)
        {
            TicketId = ticketId;
            EventName = eventName;
            EventDate = eventDate;
            Venue = venue;
            Price = price;
            IsAvailable = isAvailable;
        }

        // Methods
        public void PurchaseTicket()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Ticket ID: {TicketId} has been purchased for {EventName} on {EventDate.ToShortDateString()} at {Venue}.");
            }
            else
            {
                Console.WriteLine($"Ticket ID: {TicketId} is not available for purchase.");
            }
        }

        public void DisplayTicketInfo()
        {
            Console.WriteLine($"Ticket ID: {TicketId}");
            Console.WriteLine($"Event Name: {EventName}");
            Console.WriteLine($"Event Date: {EventDate.ToShortDateString()}");
            Console.WriteLine($"Venue: {Venue}");
            Console.WriteLine($"Price: ${Price}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Sold Out")}");
        }
    }
   




}

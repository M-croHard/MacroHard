using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ticket_Blaster.DataDB;

namespace Ticket_Blaster.Pages
{
	public class Event : PageModel
	{
		public int EventID { get; set; }
		public string EventName { get; set; } = null!;
		public string EventHost { get; set; } = null!;
		public DateTime EventDate { get; set; }
		public string EventAddress { get; set; } = null!;
		public string EventDescription { get; set; } = null!;
		public int MaxPeople { get; set; }
		public int TicketsSold { get; set; }

		public Event()
		{
			
		}

		
		
	}
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Event.Ticket_Blaster.Pages.Shared.App_code;

//int eventID, string eventName, string eventHost, DateTime eventDate, string eventAddress, int maxPeople

namespace Ticket_Blaster.Pages
{
    public class Events : PageModel
    {
        public void OnGet()
        {

        }
    }
   
}



//Event custEvent = new Event(129421, "Party", "Eli Cuchna", 4 / 12 / 2023, "Ballard Hall MSUM", 20);
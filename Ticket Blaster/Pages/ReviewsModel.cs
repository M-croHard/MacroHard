using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ticket_Blaster.Pages
{
    public class ReviewsModel : PageModel
    {
        public List<Review> Reviews { get; set; }

        public void OnGet()
        {
            // Fetch the reviews from a data source (e.g., a database) and set the Reviews property.
            // This is just a simple example, you may need to modify the code according to your specific requirements and data storage method.
            Reviews = new List<Review>
            {
                new Review { Name = "John Doe", Comment = "Great event!" },
                new Review { Name = "Jane Smith", Comment = "Had a fantastic time!" }
            };
        }

        public void OnPost(string name, string review)
        {
            // Save the submitted review to a data source (e.g., a database).
            // This is just a simple example, you may need to modify the code according to your specific requirements and data storage method.
        }
    }

    public class Review
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }
}

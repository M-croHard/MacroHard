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
                new Review { Name = "Matt Stet", Comment = "Great event!", Rating = 5 },
                new Review { Name = "Copper Staff", Comment = "Had a fantastic time!", Rating = 4 }
            };
        }

        public void OnPost(string name, string review, int rating)
        {
            // Save the submitted review to a data source (e.g., a database).
            // This is just a simple example, you may need to modify the code according to your specific requirements and data storage method.

            // Create a new Review object with the submitted data
            Review newReview = new Review
            {
                Name = name,
                Comment = review,
                Rating = rating
            };

            // Add the newReview object to your data source (e.g., a database)
            // You will need to replace this example with your own data storage implementation.
            Reviews.Add(newReview);
        }
    }

    public class Review
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();


namespace TicketBlaster.Pages
{
    public class LoginPageModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
namespace TicketBlaster.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Implement your authentication logic here

            // If the authentication is successful, redirect the user to the desired page
            return RedirectToAction("Index", "Home");

            // If the authentication fails, return the user to the login page with an error message
            // return View("LoginPage", "Invalid username or password.");
        }
    }
}
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Ticket_Blaster.Data;
using Ticket_Blaster.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Ticket_BlasterContextConnection") ?? throw new InvalidOperationException("Connection string 'Ticket_BlasterContextConnection' not found.");

builder.Services.AddDbContext<Ticket_BlasterContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<Ticket_BlasterUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Ticket_BlasterContext>();

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
app.UseAuthentication();;

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
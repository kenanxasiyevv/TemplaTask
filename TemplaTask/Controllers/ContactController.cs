using Microsoft.AspNetCore.Mvc;
using TemplaTask.DAL;
using TemplaTask.ViewModels;

namespace TemplaTask.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var contact = _dbContext.Contact.FirstOrDefault();

            ContactViewModel viewModel = new ContactViewModel
            {
                Contact = contact,
            };

            return View(viewModel);
        }
    }
}

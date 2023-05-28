using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemplaTask.DAL;

namespace TemplaTask.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {

        private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var footer = _context.Footer.Include(x => x.SocialNetworks).Include(x => x.Downloads).Include(x => x.Contacts).FirstOrDefault();

            return View(footer);
        }
    }
}

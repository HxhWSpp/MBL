using MBL.Data.Entities;
using MBL.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MBL.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
      

        public UserController(ApplicationDbContext context)
        {
            _context = context;
            
        }
        public async Task<IActionResult> ReadList()
        {
            
            var applicationDbContext = _context.UserReadBooks.Include(u => u.Book).Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
            //To do : clean shit
        }

        public async Task<IActionResult> WantedList()
        {
            
            var applicationDbContext = _context.UserWantedBooks.Include(u => u.Book).Include(u => u.User);
            return View(await applicationDbContext.ToListAsync());
            


        }
           
        public async Task<IActionResult> RemoveFromReadList(int? id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userReadList = await _context.UserReadBooks.FindAsync(id , userId);
            if (userReadList != null)
            {
                _context.UserReadBooks.Remove(userReadList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ReadList));           
        }

        public async Task<IActionResult> RemoveFromWantedList(int? id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userWantedList = await _context.UserWantedBooks.FindAsync(id, userId);
            if (userWantedList != null)
            {
                _context.UserWantedBooks.Remove(userWantedList);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(WantedList));
        }


    }
}

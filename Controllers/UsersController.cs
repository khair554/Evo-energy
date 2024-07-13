using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webdev_consultationPhotovoltaique.Models.photovoltaiqueDB;

namespace webdev_consultationPhotovoltaique.Controllers
{
    public class UsersController : Controller
    {
        private readonly PhotovoltaiqueDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public UsersController(PhotovoltaiqueDbContext context, IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult RegisterUser()
        {
            return View();
        }
        

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    _contextAccessor.HttpContext.Session.SetString("UserEmail", user.Email);
                    _contextAccessor.HttpContext.Session.SetString("MotDePasse", user.MotDePasse); // Assuming you have a Nom property
                                                                                                   // Redirect to a different action or return a success message
                    return RedirectToAction("Index", "Home"); // Redirects to Home/Index
                }
                catch (Exception ex)
                {
                    // Log the exception (you can use a logging framework here)
                    var innerException = ex.InnerException?.Message;
                    ViewBag.ErrorMessage = innerException;
                    // Optionally, you can display this error message in the view
                    ModelState.AddModelError("", "Unable to save changes: " + innerException);
                }
            }
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Prénom,Adresse,Télephone,Gouvernourat,Email,MotDePasse")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
        [HttpGet]
        public ActionResult LoginUser()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult LoginUser(User user)
        {
           
                // Handle the login logic here
                // For example, you can check the credentials against the database
                var userEmail = user.Email;
                var userPassword = user.MotDePasse;
                // Assuming you have a method to validate user credentials
                var isValidUser = ValidateUserCredentials(userEmail, userPassword);

                if (isValidUser)
                {
                _contextAccessor.HttpContext.Session.SetString("UserEmail", user.Email);
                _contextAccessor.HttpContext.Session.SetString("MotDePasse",user.MotDePasse); // Assuming you have a Nom property
                // Redirect to a different action or return a success message
                return RedirectToAction("Index", "Home"); // Redirects to Home/Index
            }
                else
                {
                    // Add an error message to the model state
                    return RedirectToAction("LoginUser");
                }
           
        }

        private bool ValidateUserCredentials(string email, string password)
        {
            // Query the database for a user with the provided email and password
            var user = _context.Users
                               .FirstOrDefault(u => u.Email == email && u.MotDePasse == password);
            
          
                var entreprise = _context.Entreprises
                               .FirstOrDefault(u => u.Email == email && u.MotDePasse == password);
            if (entreprise != null)
            {
                _contextAccessor.HttpContext.Session.SetString("mat", entreprise.ChampMatricule);
            }

            // Return true if a matching user is found, otherwise false
            return user != null || entreprise !=null;
        }
       

        

    }
}

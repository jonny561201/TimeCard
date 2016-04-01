using System.Web.Mvc;
using TimeCardWeb.Models;

namespace TimeCardWeb.Controllers
{
    public class TimeEntryController : Controller
    {
        private readonly ITimeEntryRepository _timeEntryRepository;

        public TimeEntryController() : this(new MySqlTimeEntryRepository())
        {
        }

        // Testing 
        public TimeEntryController(ITimeEntryRepository timeEntryRepository)
        {
            _timeEntryRepository = timeEntryRepository;
        }

        public ActionResult Index()
        {
            var model = new TimeEntryViewModel();
            model.ProjectName = "default";
            
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index(TimeEntryViewModel model)
        {
            if (model.IsValid())
            { 
                _timeEntryRepository.Save(model);
            }
            return View(model);
        }

//        //
//        // POST: /Account/Login
//        [HttpPost]
//        [AllowAnonymous]
//        [ValidateAntiForgeryToken]
//        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
//        {
//            if (ModelState.IsValid)
//            {
//                var user = await UserManager.FindAsync(model.UserName, model.Password);
//                if (user != null)
//                {
//                    await SignInAsync(user, model.RememberMe);
//                    return RedirectToLocal(returnUrl);
//                }
//                else
//                {
//                    ModelState.AddModelError("", "Invalid username or password.");
//                }
//            }
//
//            // If we got this far, something failed, redisplay form
//            return View(model);
//        }
    }

    public class MySqlTimeEntryRepository : ITimeEntryRepository
    {
        public void Save(TimeEntryViewModel model)
        {
            // Knows how to write dtat to mysql
           
        }
    }
}
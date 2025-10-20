using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Apply([FromBody] UserUpdateDto userUpdateDto)
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            Console.WriteLine(model.Name);
            Console.WriteLine(model.Phone);
            Console.WriteLine(model.Email);
            Console.WriteLine(model.WillAttend);
            //database
            //liste ekleme
            if (ModelState.IsValid)
            {
                Repository.CreateUserInfos(model);
                ViewBag.UserCount = Repository._userInfos.Where(i => i.WillAttend == true).Count();
                return View("Thanks", model);
            }
            else
            {
                return View(model);
            }

        }
        [HttpGet]
        public IActionResult List()
        {
            var Users = Repository._userInfos.ToList();
            return View(Users);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            var user = Repository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }
    }
}

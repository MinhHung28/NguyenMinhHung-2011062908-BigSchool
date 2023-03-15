using Microsoft.AspNet.Identity;
using NguyenMinhHung_2011062908_BigSchool.Models;
using NguyenMinhHung_2011062908_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenMinhHung_2011062908_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [Authorize] //Bắt buộc đăng nhập 
        //Email: hunglaptrinh2002@gmail.com
        //Mật khẩu:Minhhung123@
        [HttpGet] //Nhan du lieu
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
        /*public ActionResult Create()
        {
            
            return View();
        }*/
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories= _dbContext.Categories.ToList();
                return View("Create",viewModel);
            }
            var course = new Course
            {
                LecturerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),                
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            _dbContext.Courses.Add(course);
            _dbContext.SaveChanges();//luu xuong CSDL
            return RedirectToAction("Index","Home");
        }       
        /*public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }*/
        // GET: Courses
        /*public ActionResult Index()
        {
            return View();
        }*/
    }
}
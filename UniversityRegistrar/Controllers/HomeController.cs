using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;


namespace UniversityRegistrar.Controllers
{


  public class HomeController : Controller
  {
    private readonly UniversityRegistrarContext _db;

    public HomeController(UniversityRegistrarContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Student> studentModel = _db.Students.ToList();
      List<Course> courseList = _db.Courses.ToList();
      ViewBag.courseModel = courseList;
      return View(studentModel);
    }

  }
}